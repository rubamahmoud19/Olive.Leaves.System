using Microsoft.AspNetCore.Mvc;
using Olive.Leaves.System.Entities.DTOs.Branch;
using Olive.Leaves.System.Entities.Enums;
using Olive.Leaves.System.Services.Interfaces;
using Olive.Leaves.System.Web.APIs.Response;

namespace Olive.Leaves.System.Web.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanySettingsController : ControllerBase
    {
        private readonly ICompanySettingsService _companySettingsService;
        public CompanySettingsController(ICompanySettingsService companySettingsService)
        {
            _companySettingsService = companySettingsService;
        }

        [HttpPost]
        public async Task<ApiResponse<CompanySettingsDTO>> Create(CompanySettingsRequestDTO companySettingsRequestDTO)
        {
            var comanySetting = await _companySettingsService.Create(companySettingsRequestDTO);
            return new ApiResponse<CompanySettingsDTO>(comanySetting, ErrorCodesEnum.Created);
        }

        [HttpGet]
        public async Task<ApiResponse<CompanySettingsDTO>> Get(int branchId)
        {
            var comanySetting = await _companySettingsService.Get(branchId);
            return new ApiResponse<CompanySettingsDTO>(comanySetting, ErrorCodesEnum.Success);
        }
    }
}
