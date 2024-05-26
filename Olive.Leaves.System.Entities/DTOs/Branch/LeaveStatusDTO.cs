using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olive.Leaves.System.Entities.DTOs.Branch
{
    public class LeaveStatusDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int BranchId { get; set; }
    }
}
