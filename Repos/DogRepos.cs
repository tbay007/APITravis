using Microsoft.EntityFrameworkCore;
using Repos.interfaces;
using Repos.Models;
using Repos.Models.Interfaces;
using System;
using System.Collections.Generic;


namespace Repos
{
    /// <summary>
    /// Uses dbcontext for sqlite on storing information locally.  Currently labeled blogging.db.
    /// It also can get random dog information and posting the dog information
    /// </summary>
    public class DogRepos : DbContext, IDogRepos
    {
  
        public DbSet<Animal> Dogs { get; set; }
		public DbSet<AnimalVaccinations> Vaccinations { get; set; }
		public DbSet<AnimalSchedule> Schedules { get; set; }

		public string DbPath { get; }

        public DogRepos()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "dog.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }

        public Animal? GetRandomDog()
        {
            var maxId = this.Dogs.Select(x => x.Id).Max();
			int amountOfDogs = this.Dogs.Count();
            Animal? dog = null;
			if (maxId != amountOfDogs)
            {
				int randomDog = new Random().Next(maxId, maxId);
				dog = this.Dogs.Include(v => v.Vaccinations).ThenInclude(s => s.Schedule).Where(d => d.Id == randomDog).FirstOrDefault();
			}
            else
            {
				int randomDog = new Random().Next(1, maxId);
				dog = this.Dogs.Include(v => v.Vaccinations).ThenInclude(s => s.Schedule).Where(d => d.Id == randomDog).FirstOrDefault();
			}

			return dog;
        }

        public void PostDog(Dog dog)
        {
			if (dog != null)
			{
				if (dog.Vaccinations != null)
				{
					foreach (var vacc in dog.Vaccinations)
					{
						this.Schedules.Add(vacc.Schedule);
					}
					this.Vaccinations.AddRange(dog.Vaccinations);

				}
				this.Dogs.Add(dog);
			}
			this.SaveChanges();
        }

        public List<Animal>? AllDogs()
        {
            return this.Dogs?.Include(v => v.Vaccinations).ThenInclude(s => s.Schedule).ToList();
        }

        public Animal? GetSpecificDog(int id)
        {
            return this.Dogs.Include(v => v.Vaccinations).ThenInclude(s => s.Schedule).Where(dog => dog.Id == id).FirstOrDefault();
        }

        public Animal? UpdateDog(int id, Dog dog)
        {
            Animal? updateDog = this.Dogs.Include(v => v.Vaccinations).ThenInclude(s => s.Schedule).Where(d => d.Id == id).FirstOrDefault();
            if (updateDog != null)
            {
                updateDog.Title = dog.Title;
                updateDog.Description = dog.Description;
                this.Update(updateDog);
            }
            this.SaveChanges();
            return updateDog;
        }

        public void DeleteDog(int id) 
        {
            var dogToDelete = this.Dogs.Include(v => v.Vaccinations).ThenInclude(s => s.Schedule)
                                    .Where(dog => dog.Id == id).FirstOrDefault();
            if (dogToDelete != null) 
            {
                foreach (var vacc in dogToDelete.Vaccinations)
                {
                    if (vacc != null)
                    {
                        //delete schedules
                        Schedules.RemoveRange(vacc.Schedule);

                        //delete vaccinations
                        Vaccinations.Remove(vacc);
                    }
                }
                this.Remove(dogToDelete);
                this.SaveChanges();
            }
        }
    }


}
