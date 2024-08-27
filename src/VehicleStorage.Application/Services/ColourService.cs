using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Repository.Domain;
using VehicleStorage.Services.Interfaces;

namespace VehicleStorage.Services;

public class ColourService : BaseService<Colour, int>, IColourService
{
    private readonly IColourRepository _context;

    public ColourService(IColourRepository context) : base(context)
    {
        _context = context;
    }
}