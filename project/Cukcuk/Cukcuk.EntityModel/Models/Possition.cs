using System;
using System.Collections.Generic;

namespace Cukcuk.EntityModel.Models
{
    [Dapper.Contrib.Extensions.Table("Possition")]
    public partial class Possition
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid PossitionId { get; set; }
        /// <summary>
        /// Tên vị trí
        /// </summary>
        public string PossitionName { get; set; }

        public virtual Employee PossitionNavigation { get; set; }
    }
}
