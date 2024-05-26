using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Olive.Leaves.System.Entities.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olive.Leaves.System.Data.Mapping
{
    internal class LeaveStatusConfiguration : IEntityTypeConfiguration<LeaveStatus>
    {
        public void Configure(EntityTypeBuilder<LeaveStatus> builder)
        {
            builder.HasIndex(l => new { l.BranchId, l.Name }).IsUnique();
        }
    }
}
