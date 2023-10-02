using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Eurovision.API;

namespace Eurovision.API.Data
{
    public class EurovisionAPIContext : DbContext
    {
        public EurovisionAPIContext (DbContextOptions<EurovisionAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Eurovision.API.PlayerEntity> PlayerEntity { get; set; } = default!;
    }
}
