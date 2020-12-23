using System;
using System.Collections.Generic;

namespace Cukcuk.EntityModel.Models
{
    public partial class Department
    {
        public Guid DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public virtual Employee DepartmentNavigation { get; set; }
    }
}
