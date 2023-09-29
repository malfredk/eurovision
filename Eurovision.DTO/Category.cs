namespace Eurovision.DTO;

public record Category
{
    public string Name { get; init; }
    public int? Points { get; init; }

    public Category(string category, int? points)
    {
        if (!ValidateRanking(points))
        {
            throw new ArgumentException("You can give 1-8, 10 or 12 points.");
        }
        Name = category;
        Points = points;
    }

    private bool ValidateRanking(int? ranking)
    {
        int[] validRatings = { 1, 2, 3, 4, 5, 6, 7, 8, 10, 12 };
        return ranking == null || validRatings.Contains(ranking.Value);
    }
}
