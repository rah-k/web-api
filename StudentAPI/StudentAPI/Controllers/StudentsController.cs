using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public List<Studentmodel> Getstudent()
        {
            return  new List<Studentmodel>(){
                new Studentmodel() { Id = 1, Studentname = "Rahul K",RollNumber=2256},
                new Studentmodel() { Id = 2, Studentname = "Ram k",RollNumber=2255},
                new Studentmodel() { Id = 3, Studentname = "Nithish k",RollNumber=2285 } };
            } 
    }
}
