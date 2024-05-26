using Olive.Leaves.System.Entities.DTOs.LeaveTypes;

namespace Olive.Leaves.System.Entities.DTOs.Branch
{
    public class CompanySettingsDTO
    {
        public int BranchId { get; set; }
        public WorkingHoursInfoDTO WorkingHoursInfo { get; set; }
        public ICollection<LeaveTypeDTO> LeaveTypeDTOs { get; set; }
        public ICollection<LeaveStatusDTO> LeaveStatusDTOs { get; set; }
    }
}

