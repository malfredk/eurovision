using Microsoft.EntityFrameworkCore;
using Eurovision.Entity.Models.Player;

namespace Eurovision.Entity.DataAccess;

public class PlayerDbContext : DbContext
{
    public PlayerDbContext (DbContextOptions<PlayerDbContext> options)
        : base(options)
    {
    }

    public DbSet<PlayerEntity> Players { get; set; }
    public DbSet<CountryRatingEntity> CountryRatings { get; set; }
    public DbSet<CountryEntity> Countries { get; set; }
    public DbSet<CategoryEntity> Categories { get; set; }
}
