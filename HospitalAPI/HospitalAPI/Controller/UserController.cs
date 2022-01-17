using HospitalAPI.DefaultModel;
using HospitalAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private EmployeeDBSContext Employee;
        public UserController(EmployeeDBSContext employee)
        {
            Employee = employee;
        }
        [HttpGet("GetUser")]
        public IActionResult Get()
        {
            try
            {
                var user = Employee.Hospital.ToList();
                if(user.Count==0)
                {
                    return StatusCode(400, "No Data Found");
                }
                return Ok(user);
            }
            catch(Exception e)
            {
                return StatusCode(500, e.InnerException);
            }
            
        }
        [HttpGet("GetUser/{Id}")]
        public IActionResult GetUser(int Id)
        {
            try
            {
                var user = Employee.Hospital.FirstOrDefault(x => x.Id == Id);
                if(user ==null)
                {
                    return StatusCode(400, "User Not Found");
                }
                return Ok(user);
            }
            catch(Exception e)
            {
                return StatusCode(500, e.InnerException);
            }
        }
        [HttpPost("CreateUser")]
        public IActionResult Post([FromBody] UserRequest Request)
        {
            Hospital user = new Hospital();
            user.PatientName = Request.PatientName;
            user.ReasonOfAdmission = Request.ReasonOfAdmission;
            user.Age = Request.Age;
            user.DOJ = Request.DOJ;
            user.Fees = Request.Fees;
           
            try
            {
                Employee.Hospital.Add(user);
                Employee.SaveChanges();
                
            }
            catch(Exception e)
            {
                return StatusCode(500, e.InnerException);
            }
            var users = Employee.Hospital.ToList();
            return Ok(users);

        }
        [HttpPut("Upadate")]
        public IActionResult Put([FromBody] UserRequest Request)
        {
            try
            {
                var user = Employee.Hospital.FirstOrDefault(x => x.Id == Request.Id);
                if(user==null)
                {
                    return StatusCode(400, "Data Not Found");
                }
                user.PatientName = Request.PatientName;
                user.ReasonOfAdmission = Request.ReasonOfAdmission;
                user.Age = Request.Age;
                user.DOJ = Request.DOJ;
                user.Fees = Request.Fees;



                Employee.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                Employee.SaveChanges();
            }
            catch(Exception e)
            {
                return StatusCode(500, e.InnerException);

            }
            var users = Employee.Hospital.ToList();
            return Ok(users);

        }
        [HttpDelete("Delete/{Id}")]
        public IActionResult Delete(int Id)
        {
            try
            {
                var user = Employee.Hospital.FirstOrDefault(x => x.Id == Id);
                if(user == null)
                {
                    return StatusCode(400, "Data Not Found");
                }
                Employee.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                Employee.SaveChanges();
            }
            catch(Exception e)
            {
                return StatusCode(500, e.InnerException);
            }
            var users = Employee.Hospital.ToList();
            return Ok(users);
        }
    }
}
