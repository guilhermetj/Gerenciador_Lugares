
using Gerenciador_Lugares.Model;
using Gerenciador_Lugares.Model.Dtos;
using Test_BackEnd.Model;

namespace Test_BackEnd.Repository.Interfaces;

public interface IPlaceRepository
{
    Task<IEnumerable<PlaceDto>> GetPlaces(PlaceParams placeParams);
    Task<Place> GetPlaceById(int id);
    void CreatePlace(Place place);
    void UpdatePlace(Place place);
    void DeletePlace(Place place);

    Task<bool> SaveChangesAsync();
}
