using Repos.Models.Interfaces;

namespace Repos.Models
{
    public class Dog : Animal, IDog
    {
        public int Id { get; set; }
        public string? ImageUrl { get; set; }
        public string? UID { get; set; }

    }
}
