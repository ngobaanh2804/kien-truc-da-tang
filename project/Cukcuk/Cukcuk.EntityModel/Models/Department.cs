using System;
using System.Collections.Generic;

namespace Cukcuk.EntityModel.Models
{
    [Dapper.Contrib.Extensions.Table("Department")]
    public partial class Department
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid DepartmentId { get; set; }
        /// <summary>
        /// Tên phòng ban
        /// </summary>
        public string DepartmentName { get; set; }

        public virtual Employee DepartmentNavigation { get; set; }
    }
}
