using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olive.Leaves.System.Entities.DTOs.Branch
{
    public class LeaveTypeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BranchId { get; set; }
        public int Days { get; set; }
        public int PerDays { get; set; }
    }
}
