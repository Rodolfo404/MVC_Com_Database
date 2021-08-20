using Data.Models;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<M, T> : Controller where M : Base where T : BaseRepository<M>
    {
        T repository = Activator.CreateInstance<T>();

        // GET: api/<BaseController>
        [HttpGet]
        public List<M> Get()
        {
            return repository.Read();
        }

        // GET api/<BaseController>/5
        [HttpGet("{id}")]
        public M Get(int id)
        {
            return repository.Read(id);
        }

        // POST api/<BaseController>
        [HttpPost]
        public void Post([FromBody] M value)
        {
            repository.Create(value);
        }

        // PUT api/<BaseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] M value)
        {
            repository.Update(value);
        }

        // DELETE api/<BaseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
