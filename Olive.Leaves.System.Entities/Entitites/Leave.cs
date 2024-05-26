namespace Olive.Leaves.System.Entities.Entitites
{
    public class Leave : Base
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LeaveTypeId { get; set; }
        public LeaveType LeaveType { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int LeaveStatusId { get; set; }
        public virtual LeaveStatus LeaveStatus { get; set; }

    }
}
