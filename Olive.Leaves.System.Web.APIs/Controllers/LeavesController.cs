using Microsoft.AspNetCore.Mvc;
using Olive.Leaves.System.Entities.DTOs.Leaves;
using Olive.Leaves.System.Entities.Enums;
using Olive.Leaves.System.Services.Interfaces;
using Olive.Leaves.System.Web.APIs.Response;

namespace Olive.Leaves.System.Web.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeavesController : ControllerBase
    {
        private readonly ILeaveService _leaveService;
        public LeavesController(ILeaveService leaveService)
        {
            _leaveService = leaveService;
        }

        [HttpPost]
        public async Task<ApiResponse<LeaveDTO>> Create(LeaveRequestDTO leaveRequest )
        {
            var leave = await _leaveService.Create(leaveRequest);
            return new ApiResponse<LeaveDTO>(leave, ErrorCodesEnum.Created);
        }

        [HttpGet]
        public async Task<ApiResponse<LeaveDTO>> Get(int id)
        {
            var leave = await _leaveService.Get(id);
            return new ApiResponse<LeaveDTO>(leave, ErrorCodesEnum.Success);
        }
    }
}
