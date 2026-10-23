using ModeraApp.Domain.Entities.Enums;

namespace ModeraApp.Domain.Entities;

public class ClothingItem:BaseEntity
{
    public Guid UserId { get; set; }

    public string ImageUrl { get; set; } = null!;

    public ClothingCategory Category { get; set; }

    public ClothingColor Color { get; set; }

    public ClothingStyle Style { get; set; }

    public ClothingSeason Season { get; set; }

    public User User { get; set; } = null!;

    public ICollection<OutfitItem> OutfitItems { get; set; }
        = new List<OutfitItem>();
}