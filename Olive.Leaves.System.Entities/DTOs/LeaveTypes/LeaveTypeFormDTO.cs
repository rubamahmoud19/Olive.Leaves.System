namespace Olive.Leaves.System.Entities.DTOs.LeaveTypes
{
    public class LeaveTypeFormDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BranchId { get; set; }
        public int Days { get; set; }
        public int PerDays { get; set; }
    }
}
