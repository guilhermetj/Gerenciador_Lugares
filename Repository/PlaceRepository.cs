using Microsoft.EntityFrameworkCore;
using Test_BackEnd.Data;
using Test_BackEnd.Model;
using Test_BackEnd.Repository.Interfaces;

namespace Test_BackEnd.Repository;

public class PlaceRepository : IPlaceRepository
{
    private readonly PlaceContext _context;
    public PlaceRepository(PlaceContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Place>> GetPlacesParams(string name)
    {
        var places = _context.Places.AsQueryable();
        string nameplace = name.ToLower().Trim();

            places = places.Where(x => x.Name.ToLower().Contains(name));

        return await places.ToListAsync();
        
    }
    public async Task<IEnumerable<Place>> GetPlaces()
    {
        return await _context.Places.ToListAsync();

    }
    public async Task<Place> GetPlaceById(int id)
    {
        return await _context.Places.
                                    Where(x => x.Id == id).
                                    FirstOrDefaultAsync();
    }

    public void CreatePlace(Place place)
    {
        _context.Add(place);
    }

    public void UpdatePlace(Place place)
    {
        _context.Update(place);
    }


    public async void DeletePlace(Place place)
    {
        _context.Remove(place);
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}
