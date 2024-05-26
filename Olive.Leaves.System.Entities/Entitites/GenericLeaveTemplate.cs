namespace Olive.Leaves.System.Entities.Entitites
{
    public class GenericLeaveTemplate : Base
    {
        public int CountryId { get; set; }
        public string LeaveType { get; set; }
        public int Days { get; set; }
        public int PerDays { get; set; }
    }
}
