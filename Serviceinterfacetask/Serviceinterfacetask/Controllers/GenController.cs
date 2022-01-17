using Microsoft.AspNetCore.Mvc;
using Serviceinterfacetask.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Serviceinterfacetask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenController<T> : Controller where T: class

    {
        private IService<T> _gen;
        public GenController(IService<T> gen)
        {
            _gen = gen;
        }

        // GET: api/<GenController>
        [HttpGet]
        public List<T> Get()
        {
           
           
           return _gen.GetAll();
            
        
           
        }

        // GET api/<GenController>/5
        [HttpGet("{id}")]
        public T Get(int id)
        {
            try
            {
                if(id>=9)
                {
                    throw new Exception("No data found");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            return _gen.GetById(id);
        }

        // POST api/<GenController>
        [HttpPost]
        public List<T> Post([FromBody] T value)
        {
            return _gen.Insert(value);
        }

        // DELETE api/<GenController>/5
        [HttpDelete("{id}")]
        public List<T> Delete(int id)
        {
            try
            {
                if (id >= 9)
                {
                    throw new Exception("data out of boundary");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            return _gen.Delete(id);
        }
    }
}
