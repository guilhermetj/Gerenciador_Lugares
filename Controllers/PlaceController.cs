using AutoMapper;
using Gerenciador_Lugares.Model;
using Gerenciador_Lugares.Model.Dtos;
using Microsoft.AspNetCore.Mvc;
using Test_BackEnd.Model;
using Test_BackEnd.Repository.Interfaces;

namespace Test_BackEnd.Controllers;

[ApiController]
[Route("[controller]")]
public class PlaceController : ControllerBase
{
    private readonly IPlaceRepository _repository;
    private readonly IMapper _mapper;

    public PlaceController(IPlaceRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery]PlaceParams placeParams)
    {
        var places = await _repository.GetPlaces(placeParams);

        return places.Any() ? Ok(places) : NoContent();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetbyId(int id)
    {
        var places = await _repository.GetPlaceById(id);

        var placesReturn = _mapper.Map<PlaceDto>(places);

        return placesReturn != null ? Ok(placesReturn) : NotFound("place not found");
    }

    [HttpPost]
    public async Task<IActionResult> Post(Place place)
    {
        _repository.CreatePlace(place);
        return await _repository.SaveChangesAsync() ? Ok("Place created successfully") : BadRequest("Error when creating place");
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Place place)
    {
        var placeBanco = await _repository.GetPlaceById(id);
        if (placeBanco == null) return NotFound("place not found");


        placeBanco.Name = place.Name ?? placeBanco.Name;
        placeBanco.Slug = place.Slug ?? placeBanco.Slug;
        placeBanco.City = place.City ?? placeBanco.City;
        placeBanco.State = place.State ?? placeBanco.State;
        placeBanco.UpdatedAt = DateTime.Now;
        
        

        _repository.UpdatePlace(placeBanco);

        return await _repository.SaveChangesAsync() ? Ok("Place updated successfully") : BadRequest("Error when editing place");
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var placeBanco = await _repository.GetPlaceById(id);
        if (placeBanco == null) return NotFound("place not found");

        _repository.DeletePlace(placeBanco);

        return await _repository.SaveChangesAsync() ? Ok("Place deleted successfully") : BadRequest("Error deleting place");
    }

}
