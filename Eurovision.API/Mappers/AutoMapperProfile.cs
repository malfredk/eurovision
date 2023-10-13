using AutoMapper;
using Eurovision.DTO;
using Eurovision.Entity.Models.Player;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Eurovision.API.Mapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        // Player Entity to Player DTO
        CreateMap<PlayerEntity, Player>();
        CreateMap<CountryRatingEntity, CountryRating>();
        CreateMap<CountryEntity, Country>();
        CreateMap<CategoryEntity, Category>();
    }
}
