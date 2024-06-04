using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json.Linq;
using Olive.Leaves.System.Entities.DTOs;
using Olive.Leaves.System.Entities.DTOs.Leaves;
using Olive.Leaves.System.Entities.Entitites;
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

        [HttpGet("{id}")]
        public async Task<ApiResponse<LeaveDTO>> Get(int id)
        {
            var leave = await _leaveService.Get(id);
            return new ApiResponse<LeaveDTO>(leave, ErrorCodesEnum.Success);
        }

        [HttpPost("search")]
        public async Task<ApiResponse<PaginatedDataViewModel<Leave>>> Get([FromBody]List<ExpressionFilter> expressionFilters)
        {
            //Console.WriteLine(expressionFilters);
            Console.WriteLine(expressionFilters.First().Comparison);
            var filters = new List<ExpressionFilter>();
            //ExpressionFilter filterExpression = new ExpressionFilter{ PropertyName = "LeaveTypeId", Value = 1, Comparison = Comparison.Equal };
            //filters.Add(filterExpression);
            filters.AddRange(new[] { new ExpressionFilter { PropertyName= "LeaveStatusId", Value =1, Comparison = Comparison.Equal},
            new ExpressionFilter{ PropertyName = "LeaveTypeId", Value = 1, Comparison = Comparison.Equal },
            new ExpressionFilter{ PropertyName = "UserId", Value = 1, Comparison = Comparison.Equal }});
            var leave = await _leaveService.GetList(expressionFilters);
            return new ApiResponse<PaginatedDataViewModel<Leave>>(leave, ErrorCodesEnum.Success);
        }

    }
}
