namespace ModeraApp.Domain.Entities;

public class GeneratedImage : BaseEntity
{
    public Guid OutfitId { get; set; }

    public string ImageUrl { get; set; } = null!;

    public string? Prompt { get; set; }

    public Outfit Outfit { get; set; } = null!;
}