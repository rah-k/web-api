using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Models
{
    public class EmploeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EmpNo { get; set; }

        public string DOJ { get; set; }

        public int ContactNo { get; set; }
        public int Package { get; set; }
    }
}
