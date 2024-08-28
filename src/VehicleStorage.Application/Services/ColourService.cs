using AutoMapper;
using VehicleStorage.Application.Dtos;
using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Repository.Domain;
using VehicleStorage.Services.Interfaces;

namespace VehicleStorage.Services;

public class ColourService : BaseService<Colour, int>, IColourService
{
    private readonly IColourRepository _colourRepository;
    private readonly IMapper _mapper;

    public ColourService(IColourRepository colourRepository, IMapper mapper) : base(colourRepository)
    {
        _colourRepository = colourRepository;
        _mapper = mapper;
    }
    public async Task<IEnumerable<ColourDto>> GetAllColoursAsync()
    {
        var list = await _colourRepository.GetAllAsync();

        return _mapper.Map<IEnumerable<ColourDto>>(list);
    }
}