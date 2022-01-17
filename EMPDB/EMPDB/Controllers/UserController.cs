using EMPDB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATABASE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private EmployeeDBSContext _DbContext;
        public UserController(EmployeeDBSContext DbContext)
        {
            _DbContext = DbContext;
        }
        [HttpGet("Getuser")]
        public IActionResult Get()
        {
            try
            {
                var user = _DbContext.CrudTable.ToList();
                if (user.Count == 0)
                {
                    return StatusCode(400, "No Data");

                }
                return Ok(user);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }
        [HttpPost("Adduser")]
        public IActionResult Post([FromBody] UserRequest request)
        {
            CrudTable user = new CrudTable();
            user.UserName = request.UserName;
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.EmpId = request.EmpId;
            user.ContactNo = request.ContactNo;

            try
            {
                _DbContext.CrudTable.Add(user);
                _DbContext.SaveChanges();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.InnerException);
            }
            var users = _DbContext.CrudTable.ToList();
            return Ok(users);
        }

        [HttpPut("Update")]
        public IActionResult Update([FromBody] UserRequest request)
        {
            CrudTable user = new CrudTable();
            user.UserName = request.UserName;
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.EmpId = request.EmpId;
            user.ContactNo = request.ContactNo;
            try
            {

            }
            catch (Exception e)
            {
                return StatusCode(500, e.InnerException);
            }
            var users = _DbContext.CrudTable.ToList();
            return Ok(users);
        }
        [HttpDelete("delete/{Id}")]
        public IActionResult Delete([FromRoute] int Id)
        {
            try
            {
                var users = _DbContext.CrudTable.FirstOrDefault(x => x.Id == Id);
                if (users == null)
                {
                    return StatusCode(404, "user not found");
                }
                _DbContext.Entry(users).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                _DbContext.SaveChanges();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
            var user = _DbContext.CrudTable.ToList();
            return Ok(user);
        }


    }
}