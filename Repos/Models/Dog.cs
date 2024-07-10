using Repos.Models.Interfaces;

namespace Repos.Models
{
    public class Dog : Animal, IDog
    {
        public int DogId { get; set; }
        public string? ImageUrl { get; set; }
        public string? DogUID { get; set; }

    }
}
