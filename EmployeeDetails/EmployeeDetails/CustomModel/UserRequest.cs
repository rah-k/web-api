using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails.CustomModel
{
    public class UserRequest
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string City { get; set; }
    }
}
