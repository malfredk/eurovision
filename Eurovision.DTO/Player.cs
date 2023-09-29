namespace Eurovision.DTO;

public record Player
{
    public string UserName { get; init; }
    public List<CountryRating> CountryRatings { get; set; }

    public Player(string userName, List<CountryRating> countryRatings)
    {
        if (!ValidateCountryRating(countryRatings))
        {
            throw new ArgumentException("You can only give out 10 and 12 points once each in each category.");
        }
        UserName = userName;
        CountryRatings = countryRatings;
    }

    private bool ValidateCountryRating(List<CountryRating> countryRatings)
    {
        return ValidateCategory(countryRatings, (countryRating) => countryRating.Category1)
            && ValidateCategory(countryRatings, (countryRating) => countryRating.Category2)
            && ValidateCategory(countryRatings, (countryRating) => countryRating.Category3);

    }

    private bool ValidateCategory
        (
            List<CountryRating> countryRatings,
            Func<CountryRating, Category> getCategory
        )
    {
        return !HasGivenDuplicateSpecialPoints(countryRatings, getCategory, 10)
            && !HasGivenDuplicateSpecialPoints(countryRatings, getCategory, 12);
    }

    private bool HasGivenDuplicateSpecialPoints
        (
            List<CountryRating> countryRatings, 
            Func<CountryRating, Category> getCategory,
            int specialPoints
        )
    {
        bool hasGivenSpecialPoints = false;
        foreach (CountryRating countryRating in countryRatings)
        {
            if (getCategory(countryRating).Points == specialPoints)
            {
                if (hasGivenSpecialPoints)
                {
                    return true;
                }
                hasGivenSpecialPoints = true;
            }
        }
        return false;
    }
}