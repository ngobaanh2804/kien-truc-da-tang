using System;
using System.Collections.Generic;
using System.Text;

namespace Cukcuk.EntityModel.Enums
{
    public enum ApplicationStatusCode
    {
        /// <summary>
        /// Dữ liệu hợp lệ
        /// </summary>
        IsValid = 100,

        /// <summary>
        /// Dữ liệu chưa hợp lệ
        /// </summary>
        NotValid = 900,

        /// <summary>
        /// Thành công
        /// </summary>
        Success = 200,

        /// <summary>
        /// Exception
        /// </summary>
        Exception = 500
    }
}
