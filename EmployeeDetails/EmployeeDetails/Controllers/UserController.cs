using EmployeeDetails.CustomModel;
using EmployeeDetails.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private EmployeeDBSContext _dbcontext;

        public UserController(EmployeeDBSContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpGet("Getuser")]
        public IActionResult Get()
        {
            try
            {
                var user = _dbcontext.Biodata.ToList();
                if(user.Count==0)
                {
                    return StatusCode(400, "Data not Found");

                }
                return Ok(user);
            }
            catch(Exception e)
            {
                return StatusCode(500, e.InnerException);
            }
        }
        [HttpPost("AddUser")]
        public IActionResult Post([FromBody] UserRequest Request )
        {
            Biodata user = new Biodata();
            user.Name = Request.Name;
            user.Age = Request.Age;
            user.City = Request.City;

           
            try
            {
                _dbcontext.Biodata.Add(user);
               
                _dbcontext.SaveChanges();
                

            }
            catch(Exception e)
            {
                return StatusCode(500, e.InnerException);
            }
            var users = _dbcontext.Biodata.ToList();
            return Ok(users);
        }
        [HttpPut("Update")]
        public IActionResult Update([FromBody] UserRequest Request)
        {
            try
            {
                var user = _dbcontext.Biodata.FirstOrDefault(x => x.Id == Request.Id);
                if(user == null)
                {
                    return StatusCode(404, "Data not Found");
                }
                user.Name = Request.Name;
                user.Age = Request.Age;
                user.City = Request.City;

                _dbcontext.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _dbcontext.SaveChanges();
            }
            catch(Exception e)
            {
                return StatusCode(500, e.InnerException);
            }
            var users = _dbcontext.Biodata.ToList();
            return Ok(users);

        }
        [HttpDelete("Deleteuser/{Id}")]
        public IActionResult Delete(int Id)
        {
            try
            {
                var user = _dbcontext.Biodata.FirstOrDefault(x => x.Id == Id);
                if(user == null)
                {
                    return StatusCode(404, "Data not Found");
                }

                _dbcontext.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                _dbcontext.SaveChanges();

            }
            catch (Exception e)
            {
                return StatusCode(500, e.InnerException);
            }
            var users = _dbcontext.Biodata.ToList();
            return Ok(users);
        }
    }
}
