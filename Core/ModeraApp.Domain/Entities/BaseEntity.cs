namespace ModeraApp.Domain.Entities;

public abstract class BaseEntity
{
 public Guid Id { get; set; }
 public DateTime CreatedAt { get; set; }
 public DateTime UpdatedAt { get; set; }
 public bool DeletedAt { get; set; }
}