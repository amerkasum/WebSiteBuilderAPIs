using Core.Services.Service;
using Domain.Entities.System;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.EF
{
    public class LogsDbContext : DbContext
    {
        public LogsDbContext(DbContextOptions<LogsDbContext> options) : base(options)
        {   
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
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

                if (!isDeletedModified && !isDeletedDateTimeModified)
                {
                    entry.Property("ModifiedDateTime").CurrentValue = DateTime.Now;
                }

            }

            var result = base.SaveChanges();
            return result;
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
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

                if (!isDeletedModified && !isDeletedDateTimeModified)
                {
                    entry.Property("ModifiedDateTime").CurrentValue = DateTime.Now;
                }

            }

            var result = await base.SaveChangesAsync();
            return result;
        }

        #region
        public DbSet<AuditLog> AuditLog { get; set; }
        public DbSet<AuditLogEntityPropertyChange> AuditLogEntityPropertyChange { get; set; }
        #endregion
    }
}
