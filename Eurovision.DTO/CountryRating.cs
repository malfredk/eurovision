namespace Eurovision.DTO;

public record CountryRating 
    (
        Country Country, 
        Category Category1,
        Category Category2,
        Category Category3
    )
{
}
