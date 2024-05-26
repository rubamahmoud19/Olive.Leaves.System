
using Olive.Leaves.System.Entities.DTOs.Branch;

namespace Olive.Leaves.System.Services.Interfaces
{
    public interface ICompanySettingsService
    {
        Task<CompanySettingsDTO> Create(CompanySettingsRequestDTO companySettingsDTO);
        Task<CompanySettingsRequestDTO> Update(CompanySettingsRequestDTO companySettingsDTO);
        Task<CompanySettingsDTO> Get(int branchId);
    }
}
