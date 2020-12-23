using System;
using System.Collections.Generic;

namespace Cukcuk.EntityModel.Models
{
    public partial class Possition
    {
        public Guid PossitionId { get; set; }
        public string PossitionName { get; set; }

        public virtual Employee PossitionNavigation { get; set; }
    }
}
