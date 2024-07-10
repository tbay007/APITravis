using Microsoft.EntityFrameworkCore;
using Repos.interfaces;
using Repos.Models;
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
  
        public DbSet<Dog> Dogs { get; set; }

        public string DbPath { get; }

        public DogRepos()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "blogging.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }

        public Dog? GetRandomDog()
        {
            int amountOfDogs = this.Dogs.Count();
            int randomDog = new Random().Next(1, amountOfDogs);
            var dog = this.Dogs.Where(d => d.DogId == randomDog).FirstOrDefault();
            return dog;
        }

        public void PostDog(Dog dog)
        {
            this.Dogs.Add(dog);
            this.SaveChanges();
        }

        public List<Dog> AllDogs()
        {
            return this.Dogs.ToList();
        }

        public Dog? GetSpecificDog(int id)
        {
            return this.Dogs.Where(dog => dog.DogId == id).FirstOrDefault();
        }

        public Dog? UpdateDog(int id, Dog dog)
        {
            Dog? updateDog = this.Dogs.Where(d => d.DogId == id).FirstOrDefault();
            if (updateDog != null)
            {
                updateDog.Title = dog.Title;
                updateDog.DogUID = dog.DogUID;
                updateDog.Description = dog.Description;
                updateDog.ImageUrl = dog.ImageUrl;
                this.Update(updateDog);
            }
            this.SaveChanges();
            return updateDog;
        }

        public void DeleteDog(int id) 
        {
            var dogToDelete = this.Dogs.Where(dog => dog.DogId == id).FirstOrDefault();
            if (dogToDelete != null) 
            {
                this.Remove(dogToDelete);
                this.SaveChanges();
            }
        }
    }


}
