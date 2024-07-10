﻿using Microsoft.AspNetCore.Mvc;
using Repos.interfaces;
using Repos.Models;
using Repos.RepoInterfaces;

namespace APITravis.Controllers
{
    public class CatController : Controller
    {
        ICatRepos repos;
        public CatController(ICatRepos repo)
        {
            repos = repo;
        }

        /// <summary>
        /// Gets all dogs in collection AllDogs
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllCats")]
        public IActionResult GetAllCats()
        {
            return Ok(repos.AllCats());
        }

        // POST <SaveDog>
        [HttpPost("SaveCat")]
        public void Post([FromBody] Cat value)
        {
            repos.PostCat(value);
        }
    }
}
