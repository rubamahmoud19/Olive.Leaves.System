using Mapster;
using Microsoft.EntityFrameworkCore;
using Olive.Leaves.System.Data;
using Olive.Leaves.System.Entities.DTOs.Branch;
using Olive.Leaves.System.Entities.DTOs.Leaves;
using Olive.Leaves.System.Entities.DTOs.LeaveTypes;
using Olive.Leaves.System.Entities.Entitites;
using Olive.Leaves.System.Entities.Enums;
using Olive.Leaves.System.Services.Interfaces;

namespace Olive.Leaves.System.Services
{
    public class LeaveService : ILeaveService
    {
        private readonly AppDbContext _context;
        public LeaveService(AppDbContext context)
        {
            _context = context;
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
    }
}
