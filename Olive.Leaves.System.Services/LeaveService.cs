using Mapster;
using Olive.Leaves.System.Data;
using Olive.Leaves.System.Entities.DTOs;
using Olive.Leaves.System.Entities.DTOs.Leaves;
using Olive.Leaves.System.Entities.Entitites;
using Olive.Leaves.System.Entities.Enums;
using Olive.Leaves.System.Services.Interfaces;
using Olive.Leaves.System.Services.Interfaces.IRepositories;

namespace Olive.Leaves.System.Services
{
    public class LeaveService :  ILeaveService
    {
        private readonly AppDbContext _context;

        private readonly IBaseRepository<Leave> _repository;
        public LeaveService(
    
            AppDbContext context

           , IBaseRepository<Leave> repository
            )
        {
            _context = context;

            _repository = repository;
        }
        public async Task<LeaveDTO> Create(LeaveRequestDTO leaveRequestDTO)
        {
            var leave = leaveRequestDTO.Adapt<Leave>();
            _context.Leaves.Add(leave);
            await _context.SaveChangesAsync();
            return leave.Adapt<LeaveDTO>();
        }

        public async Task<LeaveDTO> Get(int leaveId)
        {
            var leave = await LeaveRecord(leaveId);
            return leave.Adapt<LeaveDTO>();
        }

        public Task<LeaveDTO> Update(LeaveRequestDTO leaveRequestDTO)
        {
            throw new NotImplementedException();
        }

        private async Task<Leave> LeaveRecord(int leaveId)
        {
            var leave = await _context.Leaves.FindAsync(leaveId);
            if (leave == null)
            {
                throw new ExceptionService(ErrorCodesEnum.NotFound, "Leave type doesn't found");
            }
            else
            {
                return leave;
            }
        }

        private Boolean IsValid(LeaveRequestDTO leaveRequest)
        {   if (leaveRequest.From >= leaveRequest.To) throw new ExceptionService(ErrorCodesEnum.BadRequest, "Invalid Date Range");

            return true;
        }

        public async Task<PaginatedDataViewModel<Leave>> GetList(List<ExpressionFilter> expressionFilters)
        {
            var res = await _repository.GetPaginatedData(1, 1, expressionFilters);
            return res;

        }
    }
}
