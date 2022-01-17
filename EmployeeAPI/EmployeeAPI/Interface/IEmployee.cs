using EmployeeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Interface
{
     public interface IEmployee
     {
        public List<EmploeeModel> GetEmp();
        public List<EmploeeModel> GetEmployee(int id);

        public List<EmploeeModel> Post(EmploeeModel emploee);
        public List<EmploeeModel> Delete(int id);
     }
}
