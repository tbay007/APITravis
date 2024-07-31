using Repos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.RepoInterfaces
{
    public interface ICatRepos
    {
        List<Animal> AllCats();
        void PostCat(Cat cat);
        Animal? GetRandomCat();

	}
}
