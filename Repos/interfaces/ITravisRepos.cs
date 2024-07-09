using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.interfaces
{
    public interface ITravisRepos
    {
        Dog? GetRandomDog();
        void PostDog(Dog dog);
        List<Dog> AllDogs();
        Dog? GetSpecificDog(int id);
        void DeleteDog(int id);
    }
}
