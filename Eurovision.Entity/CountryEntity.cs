using System.ComponentModel.DataAnnotations;

namespace Eurovision.Entity;

public record CountryEntity
{
    [Key] public int Id { get; set; }
    [Required] public string Name { get; set; }
    [Required] public int Number { get; set; }
}
