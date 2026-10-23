namespace ModeraApp.Domain.Entities;

public class Outfit : BaseEntity
{
    public Guid UserId { get; set; }

    public string? Name { get; set; }

    public User User { get; set; } = null!;

    public ICollection<OutfitItem> OutfitItems { get; set; }
        = new List<OutfitItem>();

    public ICollection<GeneratedImage> GeneratedImages { get; set; }
        = new List<GeneratedImage>();
}