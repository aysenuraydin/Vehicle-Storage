using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Repository.Domain;
using VehicleStorage.Services.Interfaces;

namespace VehicleStorage.Services;

public class BusService : BaseService<Bus, int>, IBusService
{
    private readonly IBusRepository _context;

    public BusService(IBusRepository context) : base(context)
    {
        _context = context;
    }
}