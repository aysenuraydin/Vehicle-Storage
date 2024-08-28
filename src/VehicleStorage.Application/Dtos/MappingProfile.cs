using AutoMapper;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Domain.Enums;

namespace VehicleStorage.Application.Dtos;
public class Mapping : Profile
{
    public Mapping()
    {
        CreateMap<Vehicle, VehicleDto>()
            .ForMember(a => a.Id, m => m.MapFrom(u => u.Id))
            .ForMember(a => a.Name, m => m.MapFrom(u => u.Name))
            .ForMember(a => a.CreatedDate, m => m.MapFrom(u => u.CreatedDate.ToString("yyyy-MM-dd")))
            .ForMember(a => a.ColourName, m => m.MapFrom(u => u.ColourFk != null ? u.ColourFk.ColorName : ""));

        CreateMap<Car, CarDto>()
            .ForMember(a => a.Id, m => m.MapFrom(u => u.Id))
            .ForMember(a => a.Name, m => m.MapFrom(u => u.Name))
            .ForMember(a => a.CreatedDate, m => m.MapFrom(u => u.CreatedDate.ToString("yyyy-MM-dd")))
            .ForMember(a => a.ColourName, m => m.MapFrom(u => u.ColourFk != null ? u.ColourFk.ColorName : ""))
            .ForMember(a => a.HeadlightState, m => m.MapFrom(u => u.Headlights == HeadlightStatus.On));

        CreateMap<Colour, ColourDto>()
            .ForMember(a => a.Id, m => m.MapFrom(u => u.Id))
            .ForMember(a => a.ColorName, m => m.MapFrom(u => u.ColorName));
    }
}
