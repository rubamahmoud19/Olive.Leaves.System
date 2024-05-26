using Olive.Leaves.System.Data;
using Olive.Leaves.System.Entities.DTOs.LeaveTypes;
using Olive.Leaves.System.Services.Interfaces;
using Olive.Leaves.System.Entities.Entitites;
using Mapster;
using Olive.Leaves.System.Entities.Enums;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace Olive.Leaves.System.Services
{
    public class LeaveTypeService : ILeaveTypeService
    {
        private readonly AppDbContext _context;
        public LeaveTypeService(AppDbContext context) {
            _context = context;
        }
        public async Task<LeaveTypeDTO> Create(LeaveTypeFormDTO leaveTypeDTO)
        {
            var leaveType = leaveTypeDTO.Adapt<LeaveType>();
            await _context.SaveChangesAsync();
            return leaveType.Adapt<LeaveTypeDTO>();
        }

        public async Task<bool> Delete(int leaveTypeId)
        {
            var leaveType= await LeaveTypeRecord(leaveTypeId);
            _context.LeaveTypes.Remove(leaveType);
            return true;
        }

        public Task<ICollection<LeaveTypeDTO>> List()
        {
            throw new NotImplementedException();
        }

        public Task<LeaveTypeDTO> Update(LeaveTypeFormDTO leaveTypeDTO)
        {
            throw new NotImplementedException();
        }

        private async Task<LeaveType> LeaveTypeRecord(int leaveTypeId) {
            var leaveType = await _context.LeaveTypes.FindAsync(leaveTypeId);
            if (leaveType == null)
            {
                throw new ExceptionService(ErrorCodesEnum.NotFound, "Leave type doesn't found");
            }
            else
            {
                return leaveType;
            }
        }
    }
}
