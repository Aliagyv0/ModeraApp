using Microsoft.AspNetCore.Identity;

namespace ModeraApp.Domain.Entities;

public class User:IdentityUser<Guid>
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public ICollection<ClothingItem> ClothingItems { get; set; }
        = new List<ClothingItem>();

    public ICollection<Outfit> Outfits { get; set; }
        = new List<Outfit>();   
}