using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelLib.Model;
using RestControllerPairProgramming.Managers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestControllerPairProgramming.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicRecordsController : ControllerBase
    {
        private readonly IManageMusicRecords mgr = new ManageMusicRecords();
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<MusicRecords> Get()
        {
            return mgr.Get();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public MusicRecords Get(int id)
        {
            return mgr.Get(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public bool Post([FromBody] MusicRecords value)
        {
            mgr.Create(value);
            return true;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] MusicRecords value)
        {
            mgr.Update(id, value);
            return true;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public MusicRecords Delete(int id)
        {
            MusicRecords musicRecords = mgr.Get(id);
            mgr.Delete(id);
            return musicRecords;

        }
    }
}
