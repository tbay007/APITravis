namespace Repos.Models.Interfaces
{
    public interface IDog
    {
        int DogId { get; set; }
        string? ImageUrl { get; set; }
        string? DogUID { get; set; }
    }
}
