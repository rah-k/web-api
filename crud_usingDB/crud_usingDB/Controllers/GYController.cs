using crud_usingDB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace crud_usingDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GYController : ControllerBase
    {
        private GY_DBContext _dbcontext;
        public GYController(GY_DBContext dbContext)
        {
            dbContext = _dbcontext;
        }
     

        // GET: api/<GYController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<GYController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GYController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GYController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GYController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public DefaultResponce APItest()
        {
            DefaultResponce _responce = new DefaultResponce();
            try
            {
                _responce.status = true;
                _responce.data = (from _items in _dbcontext.TblItems where _items.Id == 1 select _items);

            }
            catch(Exception e)
            {
                _responce.message = e.Message;
                _responce.status = false;
            }
            return _responce;
        }
    }
}
