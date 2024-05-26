using Microsoft.EntityFrameworkCore;
using Olive.Leaves.System.Entities.Entitites;

namespace Olive.Leaves.System.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }
        public DbSet<AnnualBalance> AnnualBalances { get; set; }
        public DbSet<GenericLeaveTemplate> GenericLeaveTemplates { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<LeaveAttachment> LeaveAttachments { get; set; }
        public DbSet<LeaveStatus> LeaveStatuses { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<WorkingHoursInfo> WorkingHoursInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            UpdateTimestamps();
            return await base.SaveChangesAsync(cancellationToken);
        }
        private void UpdateTimestamps()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is Base && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                var entity = (Base)entityEntry.Entity;
                var now = DateTime.UtcNow;

                if (entityEntry.State == EntityState.Modified)
                {
                    entity.UpdatedAt = now;
                }
                else if (entityEntry.State == EntityState.Added)
                {
                    entity.CreatedAt = now;
                    entity.UpdatedAt = now;
                }
            }
        }
    }
}
