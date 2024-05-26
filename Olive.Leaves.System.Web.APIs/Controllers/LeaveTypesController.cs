using Microsoft.AspNetCore.Mvc;
using Olive.Leaves.System.Entities.DTOs.LeaveTypes;
using Olive.Leaves.System.Entities.Enums;
using Olive.Leaves.System.Services.Interfaces;
using Olive.Leaves.System.Web.APIs.Response;

namespace Olive.Leaves.System.Web.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveTypesController : ControllerBase
    {
        private readonly ILeaveTypeService _leaveTypeService;
        public LeaveTypesController(ILeaveTypeService leaveTypeService)
        {
           _leaveTypeService = leaveTypeService;
        }

        //[HttpPost]
        //public async Task<ApiResponse<LeaveTypeDTO>> Create(LeaveTypeFormDTO leaveTypeFormDTO)
        //{
        //    var leaveType = await _leaveTypeService.Create(leaveTypeFormDTO);
        //    return new ApiResponse<LeaveTypeDTO>(leaveType, ErrorCodesEnum.Created);
        //}
    }
}
