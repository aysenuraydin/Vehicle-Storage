using VehicleStorage.Application.Dtos;
using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Repository.Domain;
using VehicleStorage.Services.Interfaces;

namespace VehicleStorage.Services;

public class ColourService : BaseService<Colour, int>, IColourService
{
    private readonly IColourRepository _colourRepository;

    public ColourService(IColourRepository colourRepository) : base(colourRepository)
    {
        _colourRepository = colourRepository;
    }
    public async Task<IEnumerable<ColoursDto>> GetAllColoursAsync()
    {
        var liste = await _colourRepository.GetAllAsync();

        return liste.Select(x => ColorsListToDTO(x)).ToList();
    }

    private static ColoursDto ColorsListToDTO(Colour p)
    {
        ColoursDto entity = new();
        if (p != null)
        {
            entity.Id = p.Id;
            entity.ColorName = p.ColorName;
        }
        return entity;
    }
}