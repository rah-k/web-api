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
    public class AdminController : ControllerBase
    {
        private EmployeeDBSContext _dbcontext;

        public AdminController(EmployeeDBSContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        [HttpGet("Getuser")]
        public IActionResult get()
        {
            try{
                
            var user = _dbcontext.Adminuser.ToList();
            if (user.Count == 0)
            {
               return StatusCode(400, "Data was not found");
            }
                return Ok(user);
            }
            catch(Exception e)
            {
                return StatusCode(500, e.InnerException);
            }
            
        }
    }
}
