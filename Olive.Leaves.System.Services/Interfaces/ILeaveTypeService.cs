using Olive.Leaves.System.Entities.DTOs.LeaveTypes;

namespace Olive.Leaves.System.Services.Interfaces
{
    public interface ILeaveTypeService
    {
        public Task<LeaveTypeDTO> Create(LeaveTypeFormDTO leaveTypeDTO);
        public Task<LeaveTypeDTO> Update(LeaveTypeFormDTO leaveTypeDTO);
        public Task<ICollection<LeaveTypeDTO>> List();
        public Task<bool> Delete(int leaveTypeId);
    }
}
