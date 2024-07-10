using Microsoft.EntityFrameworkCore;
using Repos.Models;
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
        public DbSet<Cat> Cats { get; set; }

        public string DbPath { get; }

        public CatRepos()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "cat.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }

        public void PostCat(Cat cat)
        {
            this.Cats.Add(cat);
            this.SaveChanges();
        }

        public List<Cat> AllCats()
        {
            return this.Cats.ToList();
        }
    }
}
