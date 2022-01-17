using EmployeeAPI.Interface;
using EmployeeAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployee Iemp;
        public EmployeeController(IEmployee emp)
        {
            Iemp = emp;
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<EmploeeModel> _employee = Iemp.GetEmp();
            return Ok(_employee);
        }
        [HttpGet("GetEmp")]
        public IActionResult Get(int id)

        {
           
            List<EmploeeModel> _employee = Iemp.GetEmployee(id);
            return Ok(_employee);
        }
        [HttpPost]
        public IActionResult Post(EmploeeModel emploee)
        {
            List<EmploeeModel> _employee = Iemp.Post(emploee);
            return Ok(_employee);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            List<EmploeeModel> _employee = Iemp.Delete(id);
            return Ok(_employee);
        }
    }
}
