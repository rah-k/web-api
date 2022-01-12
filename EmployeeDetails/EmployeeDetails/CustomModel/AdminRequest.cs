using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails.CustomModel
{
    public class AdminRequest
    {
        public long Id { get; set; }
        public string AdminName { get; set; }
        public string AdminLocation { get; set; }
    }
}
