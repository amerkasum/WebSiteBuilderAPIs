using Core.EF.Seed;
using Domain.Entities.Location;
using Domain.Entities.Personal;
using Domain.Entities.System;
using Domain.Entities.WebSiteBuilder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.EF
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IHttpContextAccessor HttpContextAccessor;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IHttpContextAccessor httpContexAccesor)
            : base(options)
        {
            this.HttpContextAccessor = httpContexAccesor;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }

        private void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            GeneralDatabaseSeed.Seed(modelBuilder);
            CountriesDatabaseSeed.Seed(modelBuilder);
            RegionsDatabaseSeed.Seed(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(e => e.State == EntityState.Added))
            {
                entry.Property("CreatedDateTime").CurrentValue = DateTime.Now;
                entry.Property("IsDeleted").CurrentValue = false;
            }

            foreach (var entry in ChangeTracker.Entries().Where(e => e.State == EntityState.Modified))
            
            {
               var isDeletedModified = entry.Property("IsDeleted").IsModified;
               var isDeletedDateTimeModified = entry.Property("DeletedDateTime").IsModified;

               if(!isDeletedDateTimeModified && !isDeletedDateTimeModified)
               {
                   entry.Property("ModifiedDateTime").CurrentValue = DateTime.Now;
               }
               
            }

            var auditEntries = ChangeTracker.Entries()
                               .Where(e =>
                                   e.State is EntityState.Added
                                       or EntityState.Modified
                                       or EntityState.Deleted)
                               .Where(e =>
                                   e.Metadata.GetTableName() != nameof(AuditLog) &&
                                   e.Metadata.GetTableName() != nameof(AuditLogEntityPropertyChange))
                               .ToList();

            var result = base.SaveChanges();
            OnAfterSaveChanges(auditEntries);
            base.SaveChanges(acceptAllChangesOnSuccess: false);

            ChangeTracker.AcceptAllChanges();

            return result;
        }

        private void OnAfterSaveChanges(List<EntityEntry> auditEntries)
        {
            var httpContext = HttpContextAccessor.HttpContext;

            foreach(var entry in auditEntries)
            {
                var model = entry.Metadata.GetTableName();

                //if (entry.State == EntityState.Unchanged)
                   // continue;

                //if (model == nameof(AuditLog) || model == nameof(AuditLogEntityPropertyChange))
                  //continue;

                var auditLog = new AuditLog();
                auditLog.UserId = httpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
                auditLog.HttpMethod = httpContext?.Request.Method;
                auditLog.Url = httpContext?.Request.Path.ToString();
                auditLog.BrowserInfo = httpContext?.Request.Headers["User-Agent"].ToString();
                auditLog.QueryParameters = httpContext?.Request.QueryString.ToString();
                auditLog.CreatedDateTime = DateTime.Now;

                var routeData = httpContext.GetRouteData();
                auditLog.Controller = routeData?.Values["controller"]?.ToString();
                auditLog.Method = routeData?.Values["action"]?.ToString();

                auditLog.EntityId = entry.OriginalValues[entry.Metadata.FindPrimaryKey()!.Properties.First().Name]!.ToString();
                auditLog.Table = model;

                AuditLog.Add(auditLog);
                base.SaveChanges(acceptAllChangesOnSuccess: false);

                foreach(var property in  entry.Properties)
                {
                    var propertyName = property.Metadata.Name;
                    var oldValue = property.OriginalValue?.ToString();
                    var newValue = property.CurrentValue?.ToString();

                    if(!Equals(oldValue, newValue) && !propertyName.Equals("CreatedDateTime"))
                    {
                        var auditEntityPropertyChange = new AuditLogEntityPropertyChange();
                        auditEntityPropertyChange.Property = propertyName;
                        auditEntityPropertyChange.OldValue = oldValue;
                        auditEntityPropertyChange.NewValue = newValue;
                        auditEntityPropertyChange.AuditLogId = auditLog.Id;
                        auditEntityPropertyChange.CreatedDateTime = DateTime.Now;

                        AuditLogEntityPropertyChange.Add(auditEntityPropertyChange);

                    }
                }
            }
        }

        #region DbSets
        public DbSet<User> Users { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<UserContact> UserContacts { get; set; }
        public DbSet<UserSettings> UserSettings { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<ComponentType> ComponentTypes { get; set; }
        public DbSet<BusinessType> BusinessTypes { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<MessageUs> MessageUs { get; set; }
        public DbSet<MessageUsReason> MessageUsReasons { get; set; }
        public DbSet<UserSocialMedia> UserSocialMedia { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<UserResidence> UserResidences { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Domain.Entities.System.Claim> Claim { get; set; }
        public DbSet<RoleClaim> RoleClaim { get; set; }
        public DbSet<AuditLog> AuditLog { get; set; }
        public DbSet<AuditLogEntityPropertyChange> AuditLogEntityPropertyChange { get; set; }
        #endregion

    }
}
