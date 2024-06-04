using System.Collections.ObjectModel;

namespace Olive.Leaves.System.Entities.Entitites
{
    public class LeaveType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BranchId { get; set; }
        public int Days { get; set; }
        public int PerDays {  get; set; } 
        public ICollection<Leave>Leaves { get; set; }
    }
}
