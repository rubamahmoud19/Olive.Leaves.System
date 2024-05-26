using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Olive.Leaves.System.Entities.Entitites;

namespace Olive.Leaves.System.Data.Mapping
{
        public class LeaveTypeConfiguration : IEntityTypeConfiguration<LeaveType>
        {
            public void Configure(EntityTypeBuilder<LeaveType> builder)
            {
            builder.HasIndex(l => new { l.BranchId, l.Name}).IsUnique();
            }
        }
}
