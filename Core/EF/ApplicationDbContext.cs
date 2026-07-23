using Core.EF.Seed;
using Domain.Entities.Location;
using Domain.Entities.Personal;
using Domain.Entities.System;
using Domain.Entities.WebSiteBuilder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.EF
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
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
                entry.Property("ModifiedDateTime").CurrentValue = DateTime.Now;
            }

            return base.SaveChanges();
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
        #endregion

    }
}
