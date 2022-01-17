using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMPDB.Models
{
    public class UserRequest
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmpId { get; set; }
        public string ContactNo { get; set; }
    }
}
