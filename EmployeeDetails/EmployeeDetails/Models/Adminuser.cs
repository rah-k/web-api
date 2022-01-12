using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails.Models
{
    public class Adminuser
    {
        [Key]
        public long Id { get; set; }
        public string AdminName { get; set; }
        public string AdminLocation { get; set; }
    }
}
