using Microsoft.AspNetCore.Mvc;
using Repos;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APITravis.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TravisController : ControllerBase
    {
        // GET: <GetRandomDog>
        [HttpGet("GetRandomDog")]
        public Dog? Get()
        {
            using var db = new TravisRepos();
            // Note: This sample requires the database to be created before running.
            Console.WriteLine($"Database path: {db.DbPath}.");
            var dog = db.GetRandomDog();
            return dog;
        }

        /// <summary>
        /// Gets all dogs in collection AllDogs
        /// </summary>
        /// <returns></returns>
        [HttpGet("AllDogs")]
        public List<Dog> GetAllDogs()
        {
            using var db = new TravisRepos();
            return db.AllDogs();
        }

        // GET <TravisController>/5
        [HttpGet("GetDog/{id}")]
        public string Get(int id)
        {

            return "value";
        }

        // POST <SaveDog>
        [HttpPost("SaveDog")]
        public void Post([FromBody] Dog value)
        {
            using var db = new TravisRepos();
            db.PostDog(value);
        }

        // PUT <TravisController>/5
        [HttpPut("UpdateDog/{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE <TravisController>/5
        [HttpDelete("DeleteDog/{id}")]
        public ActionResult Delete(int id)
        {
            if (id == 0) { return NotFound(); };
            using var db = new TravisRepos();
            db.DeleteDog(id);
            return Ok();
        }
    }
}
