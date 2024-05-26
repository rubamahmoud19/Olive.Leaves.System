using Olive.Leaves.System.Entities.Enums;

namespace Olive.Leaves.System.Web.APIs.Response
{
    public class ApiException : ApiResponse<object>
    {
        public ApiException(object data = default, ErrorCodesEnum statusCode = ErrorCodesEnum.InternalServerError, string message = null, string details = null)
    : base(data, statusCode, message)
        {
            Details = details;
        }
        public ApiException(int statusCode = 500, string message = null, string details = null)
            : base(statusCode, message)
        {
            Details = details;
        }


        public string Details { get; set; }
    }
}

