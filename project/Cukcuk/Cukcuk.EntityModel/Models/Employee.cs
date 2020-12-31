using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cukcuk.EntityModel.Models
{
    [Dapper.Contrib.Extensions.Table("Employee")]
    public partial class Employee
    {
        [ExplicitKey]

        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid EmployeeId { get; set; }
        /// <summary>
        /// Mã nhân viên
        /// </summary>
        public string EmployeeCode { get; set; }
        /// <summary>
        /// Tên nhân viên
        /// </summary>
        public string EmployeeName { get; set; }
        /// <summary>
        /// Giới tính ( 0-Nam, 1-Nữ)
        /// </summary>
        public int? Gender { get; set; }
        /// <summary>
        /// Ngày sinh
        /// </summary>
        public DateTime? Birthday { get; set; }
        /// <summary>
        /// Số điện thoại
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Quốc tịch
        /// </summary>
        public string National { get; set; }
        /// <summary>
        /// Số CMT
        /// </summary>
        public string Identification { get; set; }
        /// <summary>
        /// Ngày cấp
        /// </summary>
        public DateTime? IssueDate { get; set; }
        /// <summary>
        /// Nơi cấp
        /// </summary>
        public string IssueBy { get; set; }
        /// <summary>
        /// Phòng ban
        /// </summary>
        public Guid DepartmentId { get; set; }
        /// <summary>
        /// Vị trí
        /// </summary>
        public Guid PossitionId { get; set; }
        /// <summary>
        /// Lương nhân viên
        /// </summary>
        public decimal? Salary { get; set; }

        public virtual Department Department { get; set; }
        public virtual Possition Possition { get; set; }
    }
}
