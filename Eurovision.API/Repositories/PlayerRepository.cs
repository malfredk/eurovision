using Eurovision.API.Data;
using Eurovision.API.Repository.Contract;
using Eurovision.Entity;
using Microsoft.EntityFrameworkCore;

namespace Eurovision.API.Repository;

public class PlayerRepository : IPlayerRepository
{
    private readonly EurovisionDbContext context;

    public PlayerRepository(EurovisionDbContext context)
    {
        this.context = context;
    }

    public async Task<IEnumerable<PlayerEntity>> GetPlayers()
    {
        return await this.context.Players.ToListAsync();
    }  

    public Task<PlayerEntity> GetPlayer(string userName)
    {
        throw new NotImplementedException();
    }

    public Task<PlayerEntity> UpdatePlayer(PlayerEntity player)
    {
        throw new NotImplementedException();
    }
}
