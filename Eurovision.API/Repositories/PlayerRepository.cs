using Eurovision.API.Repository.Contract;
using Eurovision.Entity.DataAccess;
using Eurovision.Entity.Models.Player;

namespace Eurovision.API.Repository;

public class PlayerRepository : IPlayerRepository
{
    private readonly PlayerDbContext _context;

    public PlayerRepository(PlayerDbContext context)
    {
        this._context = context;
    }

    IEnumerable<PlayerEntity> IPlayerRepository.GetPlayers()
    {
        return _context.Players;
    }

    public PlayerEntity GetPlayer(int id)
    {
        return _context.Players.Single(player => player.Id == id);
    }

    public PlayerEntity GetPlayer(string userName)
    {
        return _context.Players.Single(player => player.UserName == userName);
    }

    public bool UpdateCountryRating(CountryRatingEntity countryRating)
    {
        throw new NotImplementedException();
    }

    public PlayerEntity? CreatePlayer(string userName)
    {
        PlayerEntity? existingPlayer = _context.Players.SingleOrDefault(player => player.UserName == userName);
        if (existingPlayer != null)
        {
            return null;
        }

        PlayerEntity newPlayer = new PlayerEntity()
        {
            UserName = userName
        };
        _context.Players.Add(newPlayer);

        return newPlayer;
    }
}
