using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serviceinterfacetask.Models;
using Serviceinterfacetask.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serviceinterfacetask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : GenController<Student>
    {
        public StudentController(IService<Student> service) : base(service)
        {


        }
    }
}
