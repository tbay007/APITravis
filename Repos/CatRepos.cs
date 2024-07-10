using Microsoft.EntityFrameworkCore;
using Repos.RepoInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos
{
    public class CatRepos : DbContext, ICatRepos
    {
    }
}
