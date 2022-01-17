using EmployeeAPI.Interface;
using EmployeeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Repository
{
    public class Employee_Repo : IEmployee
    {
        List<EmploeeModel> _employee = new List<EmploeeModel>()
        {
            new EmploeeModel(){Id=1,Name="Rahul",EmpNo=1001,DOJ="FEB-20-21",ContactNo=1225,Package=15000},
            new EmploeeModel(){Id=2,Name="Gokul",EmpNo=1002,DOJ="MAR-10-21",ContactNo=16525,Package=15000},
            new EmploeeModel(){Id=3,Name="Hari",EmpNo=1003,DOJ="DEC-30-21",ContactNo=1585,Package=20000},
            new EmploeeModel(){Id=4,Name="Ram",EmpNo=1004,DOJ="JAN-02-21",ContactNo=1285,Package=18000},
            new EmploeeModel(){Id=5,Name="Saran",EmpNo=1005,DOJ="APR-21-21",ContactNo=1625,Package=12000},
            new EmploeeModel(){Id=6,Name="David",EmpNo=1006,DOJ="FEB-20-21",ContactNo=1825,Package=14000}
        };
        public List<EmploeeModel> GetEmp()
        {
            try 
            {

                if (_employee.Count == 6)
                {
                    return _employee;
                }
                else
                {
                    throw new NotImplementedException();
                }

            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }
        public EmploeeModel GetEmployee( int id)
        {
            var Employee =_employee.SingleOrDefault(x => x.Id == id);
           
            return Employee;
        }
        public List<EmploeeModel> Post(EmploeeModel emploee)
        {
            _employee.Add(emploee);
            try
            {
                if (_employee.Count == 0)
                {
                    throw new NotFiniteNumberException();
                }
                else
                {
                    return _employee;
                }      
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        public List<EmploeeModel> Delete(int id)
        {
            
            
                var emploee = _employee.SingleOrDefault(x => x.Id == id);
               

                _employee.Remove(emploee);
                return _employee;
           

        }
       
    }
}
