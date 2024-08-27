using VehicleStorage.Application.Interfaces;
using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Repository.Domain;
using VehicleStorage.Services.Interfaces;

namespace VehicleStorage.Services;
public class BoatService : BaseService<Boat, int>, IBoatService
{
    private readonly IBoatRepository _context;

    public BoatService(IBoatRepository context) : base(context)
    {
        _context = context;
    }
}