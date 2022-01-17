using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_DB.Models
{
    public class UserRequest
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmpId { get; set; }
        public string ContactNo { get; set; }
    }
}

