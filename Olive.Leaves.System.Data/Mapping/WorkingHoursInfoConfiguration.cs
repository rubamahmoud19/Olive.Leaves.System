using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Olive.Leaves.System.Entities.Entitites;

namespace Olive.Leaves.System.Data.Mapping
{
    public class WorkingHoursInfoConfiguration : IEntityTypeConfiguration<WorkingHoursInfo>
    {
        public void Configure(EntityTypeBuilder<WorkingHoursInfo> builder)
        {
            builder.HasIndex(w => w.BranchId).IsUnique();
        }
    }
}
