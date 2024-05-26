namespace Olive.Leaves.System.Entities.Entitites
{
    public class LeaveStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BranchId { get; set; }
        public ICollection<Leave> Leaves { get; set; }
    }
}
