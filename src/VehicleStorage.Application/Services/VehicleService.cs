using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Repository.Domain;
using VehicleStorage.Services.Interfaces;

namespace VehicleStorage.Services;

public class VehicleService : BaseService<Vehicle, int>, IVehicleService
{
    private readonly IVehicleRepository _context;

    public VehicleService(IVehicleRepository context) : base(context)
    {
        _context = context;
    }

    //farları ac kapa
}