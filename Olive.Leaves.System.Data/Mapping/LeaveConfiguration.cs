using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Olive.Leaves.System.Entities.Entitites;

namespace Olive.Leaves.System.Data.Mapping
{
    public  class LeaveConfiguration : IEntityTypeConfiguration<Leave>
    {
        public void Configure(EntityTypeBuilder<Leave> builder)
        {
             
        }
    }
}
