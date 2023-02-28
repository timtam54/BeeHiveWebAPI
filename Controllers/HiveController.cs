using BeeHive.Data;
using BeeHive.Models.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BeeHive.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HiveController : ControllerBase
    {
        private readonly dbcontext _context;

        public HiveController(dbcontext context)
        {
            _context = context;
            
        }

        [HttpGet]
        public IEnumerable<Hive> Get()
        {
            return _context.Hives.ToList().ToArray();
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public IEnumerable<Hive> Get(int id)
        {
            return _context.Hives.Where(i=>i.clientid==id).ToList().ToArray();
        }

        // POST api/<ClientController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
