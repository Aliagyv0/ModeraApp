namespace ModeraApp.Domain.Entities;

public class OutfitItem : BaseEntity
{
    public Guid OutfitId { get; set; }

    public Guid ClothingItemId { get; set; }

    public Outfit Outfit { get; set; } = null!;

    public ClothingItem ClothingItem { get; set; } = null!;
}