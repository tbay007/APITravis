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
        List<Cat> AllCats();
        void PostCat(Cat cat);
    }
}
