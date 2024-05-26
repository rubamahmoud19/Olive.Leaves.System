namespace Olive.Leaves.System.Entities.Entitites
{
    public class WorkingHoursInfo
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int PerDays { get; set; }
        public string  Weekend { get; set; }
        public float MaxiumHours { get; set; }
        public float MiniumHours { get; set;}
    }
}
