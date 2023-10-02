using System.ComponentModel.DataAnnotations;

namespace Eurovision.Entity;

public record PlayerEntity
{
    [Key] public int Id { get; set; }
    public string UserName { get; set; }
    public List<CountryRatingEntity> CountryRatings { get; set; }
}