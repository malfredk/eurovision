using System.ComponentModel.DataAnnotations;

namespace Eurovision.Entity;

public record CategoryEntity
{
    [Key] public int Id { get; set; }
    [Required] public string Name { get; set; }
    public int Points { get; set; }
}
