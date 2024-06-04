using System.ComponentModel.DataAnnotations;

namespace Olive.Leaves.System.Entities.DTOs.Leaves
{
    public class LeaveRequestDTO
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int LeaveTypeId { get; set; }
        [Required]
        public DateTime From { get; set; }
        [Required]
        public DateTime To { get; set; }
        [Required]
        public int LeaveStatusId { get; set; }
    }
}
