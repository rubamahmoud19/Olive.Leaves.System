using Olive.Leaves.System.Entities.Entitites;

namespace Olive.Leaves.System.Entities.DTOs.Leaves
{
    public class LeaveRequestDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int LeaveStatusId { get; set; }
    }
}
