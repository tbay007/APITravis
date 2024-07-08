using Microsoft.AspNetCore.Mvc;
using Repos;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APITravis.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TravisController : ControllerBase
    {
        // GET: <TravisController>
        [HttpGet("GetPuppies")]
        public Dog? Get()
        {
             
            using var db = new TravisRepos();
            // Note: This sample requires the database to be created before running.
            Console.WriteLine($"Database path: {db.DbPath}.");
            var dog = db.GetRandomDog();

            return dog;
        }

        // GET <TravisController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {

            return "value";
        }

        // POST <TravisController>
        [HttpPost("SaveDog")]
        public void Post([FromBody] Dog value)
        {
            using var db = new TravisRepos();
            db.PostDog(value);
        }

        // PUT <TravisController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE <TravisController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
