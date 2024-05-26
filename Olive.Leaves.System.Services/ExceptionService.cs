using Olive.Leaves.System.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olive.Leaves.System.Services
{
    public class ExceptionService : Exception
    {
        public ExceptionService(ErrorCodesEnum errorCode, params object[] data) : base(data[0].ToString())
        {
            ErrorCode = errorCode;
            ErrorData = data;
        }
        public ExceptionService(ErrorCodesEnum errorCode) : base(errorCode.ToString())
        {
            ErrorCode = errorCode;
        }

        public ErrorCodesEnum ErrorCode { get; }
        public object[] ErrorData { get; }
    }
}
