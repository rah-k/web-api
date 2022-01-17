using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApiTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentAPI : ControllerBase
    {

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
           
        }
    }
}
