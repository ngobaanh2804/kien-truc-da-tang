using System;
using System.Collections.Generic;
using System.Text;

namespace Cukcuk.EntityModel.Models
{
    public class ServiceResult
    {
        public int ApplicationSatusCode { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }
    }
}
