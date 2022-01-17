using Employee_DB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employee_DB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private DatabaseContext _Dbcontext;
        public UserController(DatabaseContext Dbcontext)
        {
            _Dbcontext = Dbcontext;
        }
        
        // GET api/<UserController>/5
        [HttpGet("GetUser")]
        public IActionResult Get()
        {
            var user = _Dbcontext.Tableuser.ToList();
            if(user.Count == 0)
            try
            {
                    return StatusCode(400, "Data not found");
            }
            catch(Exception e)
            {
                return StatusCode(500, e.InnerException);
            }

            return Ok(user);
        }

        // POST api/<UserController>
        [HttpPost("AddUser")]
        public IActionResult Post([FromBody]  UserRequest Request)
        {
            Tableuser user = new Tableuser();
            user.Username = Request.Username;
            user.FirstName = Request.FirstName;
            user.LastName = Request.LastName;
            user.EmpId = Request.EmpId;
            user.ContactNo = Request.ContactNo;
            try
            {
                _Dbcontext.Tableuser.Add(user);
                _Dbcontext.SaveChanges();
            }
            catch(Exception e)
            {
                return StatusCode(500, e.InnerException);
            }
            var users = _Dbcontext.Tableuser.ToList();
            return Ok(users);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
