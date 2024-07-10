using Repos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.interfaces
{
    public interface IDogRepos
    {
        /// <summary>
        /// Gets a random dog in the collection of dogs
        /// </summary>
        /// <returns></returns>
        Dog? GetRandomDog();
        /// <summary>
        /// This will save a new dog to the db
        /// </summary>
        /// <param name="dog"></param>
        void PostDog(Dog dog);
        /// <summary>
        /// Grabs all existing dogs
        /// </summary>
        /// <returns></returns>
        List<Dog> AllDogs();
        /// <summary>
        /// Grabs a specific dog
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Dog? GetSpecificDog(int id);
        /// <summary>
        /// Deletes a dog from the db
        /// </summary>
        /// <param name="id"></param>
        void DeleteDog(int id);
        /// <summary>
        /// Updates the existing dog
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dog"></param>
        /// <returns></returns>
        Dog? UpdateDog(int id, Dog dog);
    }
}
