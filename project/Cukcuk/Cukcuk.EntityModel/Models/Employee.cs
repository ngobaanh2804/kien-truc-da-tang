using System;
using System.Collections.Generic;

namespace Cukcuk.EntityModel.Models
{
    public partial class Employee
    {
        public Guid EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public int? Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string National { get; set; }
        public string Identification { get; set; }
        public DateTime? IssueDate { get; set; }
        public string IssueBy { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid PossitionId { get; set; }
        public decimal? Salary { get; set; }

        public virtual Department Department { get; set; }
        public virtual Possition Possition { get; set; }
    }
}
