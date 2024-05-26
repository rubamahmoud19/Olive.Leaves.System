using Mapster;
using Microsoft.EntityFrameworkCore;
using Olive.Leaves.System.Data;
using Olive.Leaves.System.Entities.DTOs.Branch;
using Olive.Leaves.System.Entities.DTOs.LeaveTypes;
using Olive.Leaves.System.Entities.Entitites;
using Olive.Leaves.System.Services.Interfaces;

namespace Olive.Leaves.System.Services
{
    public class CompanySettingsService : ICompanySettingsService
    {
        private readonly AppDbContext _context;
        public CompanySettingsService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<CompanySettingsDTO> Create(CompanySettingsRequestDTO companySettingsRequestDTO)
        {

            if (companySettingsRequestDTO == null)
            {
                throw new ArgumentNullException(nameof(companySettingsRequestDTO));
            }
            var workingHoursInfo = companySettingsRequestDTO.WorkingHoursInfo.Adapt<WorkingHoursInfo>();
            var leaveStatuses = companySettingsRequestDTO.LeaveStatusDTOs.Select(ls => ls.Adapt<LeaveStatus>()).ToList();
            var leaveTypes = companySettingsRequestDTO.LeaveTypeDTOs.Select(lt => lt.Adapt<LeaveType>()).ToList();
            _context.WorkingHoursInfo.Add(workingHoursInfo);
            await _context.LeaveStatuses.AddRangeAsync(leaveStatuses);
            await _context.LeaveTypes.AddRangeAsync(leaveTypes);
            await  _context.SaveChangesAsync();
            var companySettingsDTO = await Get(companySettingsRequestDTO.BranchId);
            return companySettingsDTO;
        }

        public Task<CompanySettingsRequestDTO> Update(CompanySettingsRequestDTO companySettingsDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<CompanySettingsDTO> Get(int branchId)
        {
            var savedWorkingHoursInfo = await _context.WorkingHoursInfo.SingleOrDefaultAsync(w => w.BranchId == branchId);
            var savedLeaveStatuses = await _context.LeaveStatuses.Where(ls => ls.BranchId == branchId).ToListAsync();
            var savedLeaveTypes =  await _context.LeaveTypes.Where(lt => lt.BranchId == branchId).ToListAsync();

            var resultDTO = new CompanySettingsDTO
            {
                BranchId = branchId,
                WorkingHoursInfo = savedWorkingHoursInfo.Adapt<WorkingHoursInfoDTO>(),
                LeaveStatusDTOs = savedLeaveStatuses.Adapt<List<LeaveStatusDTO>>(),
                LeaveTypeDTOs = savedLeaveTypes.Adapt<List<Entities.DTOs.Branch.LeaveTypeDTO>>()
            };
            return resultDTO;
        }
    }
}
