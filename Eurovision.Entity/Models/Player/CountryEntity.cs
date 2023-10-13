using System.ComponentModel.DataAnnotations;

namespace Eurovision.Entity.Models.Player;

public record CountryEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Number { get; set; }
    public CountryRatingEntity CountryRating { get; set; }
}
