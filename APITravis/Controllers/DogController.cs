using Microsoft.AspNetCore.Mvc;
using Repos;
using Repos.interfaces;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APITravis.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DogController : ControllerBase
    {
        ITravisRepos repos;
        public DogController(ITravisRepos repo) 
        {
            repos = repo;
        }

        // GET: <GetRandomDog>
        [HttpGet("GetRandomDog")]
        public Dog? Get()
        {
            var dog = repos.GetRandomDog();
            return dog;
        }

        /// <summary>
        /// Gets all dogs in collection AllDogs
        /// </summary>
        /// <returns></returns>
        [HttpGet("AllDogs")]
        public List<Dog> GetAllDogs()
        {
            return repos.AllDogs();
        }

        // GET <TravisController>/5
        [HttpGet("GetDog/{id}")]
        public Dog? Get(int id)
        {
            var dog = repos.GetSpecificDog(id);
            return dog;
        }

        // POST <SaveDog>
        [HttpPost("SaveDog")]
        public void Post([FromBody] Dog value)
        {
            repos.PostDog(value);
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
            repos.DeleteDog(id);
            return Ok();
        }
    }
}
