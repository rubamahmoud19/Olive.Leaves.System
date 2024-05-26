using System.ComponentModel.DataAnnotations;


namespace Olive.Leaves.System.Entities.DTOs.LeaveTypes
{
    public class LeaveTypeDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int BranchId { get; set; }
        public int Days { get; set; }
        public int PerDays { get; set; }
    }
}
