using System.ComponentModel.DataAnnotations;

namespace Eurovision.Entity.Models.Player;

public record CategoryEntity
{
    public int Id { get; set; }
    [Required] public string Name { get; set; }
    public int? Points { get; set; }
    public CountryRatingEntity CountryRating { get; set; }
}
