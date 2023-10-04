using Eurovision.Entity;

namespace Eurovision.API.Repository.Contract;

public interface IPlayerRepository
{
    Task<IEnumerable<PlayerEntity>> GetPlayers();
    Task<PlayerEntity> GetPlayer(string userName);
    Task<PlayerEntity> UpdatePlayer(PlayerEntity player);
}
