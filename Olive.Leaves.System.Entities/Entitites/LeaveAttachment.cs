namespace Olive.Leaves.System.Entities.Entitites
{
    public class LeaveAttachment : Base
    {
        public int LeaveId {get; set;}
        public Leave Leave { get; set;} 
        public int AttachmentId { get; set;}
    }
}
