using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ModeraApp.Domain.Entities;

namespace ModeraApp.Persistence.Context;

public class AppDbContext
 : IdentityDbContext<User, IdentityRole<Guid>, Guid>
{
 public AppDbContext(DbContextOptions<AppDbContext> options)
  : base(options)
 {
  
 }
 public DbSet<ClothingItem> ClothingItems { get; set; }
 public DbSet<Outfit> Outfits { get; set; }
 public DbSet<GeneratedImage> GeneratedImages { get; set; }
 public DbSet<OutfitItem> OutfitItems { get; set; }


 protected override void OnModelCreating(ModelBuilder builder)
 {
  builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
  base.OnModelCreating(builder);
 }
}