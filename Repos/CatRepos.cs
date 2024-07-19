using Microsoft.EntityFrameworkCore;
using Repos.Models;
using Repos.RepoInterfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos
{
    public class CatRepos : DbContext, ICatRepos
    {
        public DbSet<Cat> Cats { get; set; }
        public DbSet<AnimalVaccinations> Vaccinations { get; set; }
        public DbSet<AnimalSchedule> Schedules { get; set; }
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
            if (cat != null)
            {
                if (cat.Vaccinations != null)
                {
                    foreach(var vacc in cat.Vaccinations)
                    {
                        this.Schedules.Add(vacc.Schedule);
                    }
                    this.Vaccinations.AddRange(cat.Vaccinations);
                    
                }
				this.Cats.Add(cat);
			}

            this.SaveChanges();
        }

        public List<Cat> AllCats()
        {
            return this.Cats.ToList();
        }
    }
}
