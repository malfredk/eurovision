using System.ComponentModel.DataAnnotations;

namespace Eurovision.Entity.Models.Player;

public record CountryRatingEntity
{
    public int Id { get; set; }
    public CountryEntity Country { get; set; }
    public CategoryEntity Category1 { get; set; }
    public CategoryEntity Category2 { get; set; }
    public CategoryEntity Category3 { get; set; }
    public PlayerEntity Player { get; set; }

}
