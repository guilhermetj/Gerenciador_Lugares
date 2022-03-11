using Gerenciador_Lugares.Model;
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

    public async Task<IEnumerable<Place>> GetPlaces(PlaceParams placeParams)
    {
        var places = _context.Places.AsQueryable();

        if(!string.IsNullOrEmpty(placeParams.NamePlace))
        {
            string nameplace = placeParams.NamePlace.ToLower().Trim();

            places = places.Where(x => x.Name.ToLower().Contains(nameplace));
        }

        return await places.ToListAsync();
        
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
