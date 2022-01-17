using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_usingDB.Models
{
    public class DefaultResponce
    {
        public dynamic data { get; set; }
        public bool status { get; set; }
        public string message { get; set; }
    }
}
