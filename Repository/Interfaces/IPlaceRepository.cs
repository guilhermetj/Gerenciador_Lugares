
using Test_BackEnd.Model;

namespace Test_BackEnd.Repository.Interfaces;

public interface IPlaceRepository
{
    Task<IEnumerable<Place>> GetPlacesParams(string name);
    Task<IEnumerable<Place>> GetPlaces();
    Task<Place> GetPlaceById(int id);
    void CreatePlace(Place place);
    void UpdatePlace(Place place);
    void DeletePlace(Place place);

    Task<bool> SaveChangesAsync();
}
