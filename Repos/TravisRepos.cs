using Microsoft.EntityFrameworkCore;
using Repos.interfaces;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Repos
{
    /// <summary>
    /// Uses dbcontext for sqlite on storing information locally.  Currently labeled blogging.db.
    /// It also can get random dog information and posting the dog information
    /// </summary>
    public class TravisRepos : DbContext, ITravisRepos
    {
  
        public DbSet<Dog> Dogs { get; set; }

        public string DbPath { get; }

        public TravisRepos()
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

    public class Dog : Animal, IDog
    {
        public int DogId { get; set; }
        public string? ImageUrl { get; set; }
        public string? DogUID { get; set; }

    }

    public abstract class Animal
    {
        public int AnimalId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
    
    public interface IDog
    {
        int DogId { get; set; }
        string? ImageUrl { get; set; }
        string? DogUID { get; set; }
    }
}
