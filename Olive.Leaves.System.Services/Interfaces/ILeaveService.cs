using Olive.Leaves.System.Entities.DTOs.Leaves;

namespace Olive.Leaves.System.Services.Interfaces
{
    public interface ILeaveService
    {
        Task<LeaveDTO> Create(LeaveRequestDTO leaveRequestDTO);
        Task<LeaveDTO> Update(LeaveRequestDTO leaveRequestDTO);
        Task<LeaveDTO> Get(int leaveId);
    }
}
