using System.ComponentModel.DataAnnotations;

namespace Eurovision.Entity.Models.Player;

public record PlayerEntity
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public List<CountryRatingEntity> CountryRatings { get; set; }
}