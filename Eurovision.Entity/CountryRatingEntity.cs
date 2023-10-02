using System.ComponentModel.DataAnnotations;

namespace Eurovision.Entity;

public record CountryRatingEntity
{
    [Key] public int Id { get; set; }
    [Required] public CountryEntity Country { get; set; }
    public CategoryEntity Category1 { get; set; }
    public CategoryEntity Category2 { get; set; }
    public CategoryEntity Category3 { get; set; }

}
