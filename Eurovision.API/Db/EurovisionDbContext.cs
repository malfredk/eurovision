using Microsoft.EntityFrameworkCore;
using Eurovision.Entity;

namespace Eurovision.API.Data;

public class EurovisionDbContext : DbContext
{
    public EurovisionDbContext (DbContextOptions<EurovisionDbContext> options)
        : base(options)
    {
    }

    public DbSet<PlayerEntity> Players { get; set; } = default!;
}
