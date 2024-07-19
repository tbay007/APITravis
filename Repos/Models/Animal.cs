using System.ComponentModel.DataAnnotations;

namespace Repos.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<AnimalVaccinations>? Vaccinations { get; set; } = new List<AnimalVaccinations>();
    }
}
