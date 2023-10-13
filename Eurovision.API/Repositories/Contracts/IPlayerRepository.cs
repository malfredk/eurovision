using Eurovision.Entity.Models.Player;

namespace Eurovision.API.Repository.Contract;

public interface IPlayerRepository
{
    IEnumerable<PlayerEntity> GetPlayers();
    PlayerEntity GetPlayer(int id);
    PlayerEntity GetPlayer(string userName);
    bool UpdateCountryRating(CountryRatingEntity countryRating);
    PlayerEntity? CreatePlayer(string userName);
}
