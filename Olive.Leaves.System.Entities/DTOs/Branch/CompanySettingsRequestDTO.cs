namespace Olive.Leaves.System.Entities.DTOs.Branch
{
    public class CompanySettingsRequestDTO
    {
        public int BranchId { get; set; }
        public WorkingHoursInfoDTO WorkingHoursInfo { get; set; }
        public ICollection<LeaveTypeDTO>  LeaveTypeDTOs { get; set; }
        public ICollection<LeaveStatusDTO> LeaveStatusDTOs { get; set; }  
    }
}
