using AutoMapper;
using Gerenciador_Lugares.Model.Dtos;
using Test_BackEnd.Model;

namespace Gerenciador_Lugares.Helpers;

public class GerenciadorLugaresProfile : Profile
{
    public GerenciadorLugaresProfile()
    {
        CreateMap<Place, PlaceDto>();

        CreateMap<PlaceCreateDto, Place>();

        CreateMap<PlaceUpdateDto, Place>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
    }
}
