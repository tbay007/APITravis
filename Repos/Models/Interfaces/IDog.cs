namespace Repos.Models.Interfaces
{
    public interface IDog
    {
        int Id { get; set; }
        string? ImageUrl { get; set; }
        string? UID { get; set; }
    }
}
