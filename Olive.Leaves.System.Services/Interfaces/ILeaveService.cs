using Olive.Leaves.System.Entities.DTOs;
using Olive.Leaves.System.Entities.DTOs.Leaves;
using Olive.Leaves.System.Entities.Entitites;

namespace Olive.Leaves.System.Services.Interfaces
{
    public interface ILeaveService
    {
        Task<LeaveDTO> Create(LeaveRequestDTO leaveRequestDTO);
        Task<LeaveDTO> Update(LeaveRequestDTO leaveRequestDTO);
        Task<LeaveDTO> Get(int leaveId);
        Task<PaginatedDataViewModel<Leave>> GetList(List<ExpressionFilter> expressionFilters);
    }
}
