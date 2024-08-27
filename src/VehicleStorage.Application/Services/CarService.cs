using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Repository.Domain;
using VehicleStorage.Services.Interfaces;

namespace VehicleStorage.Services;

public class CarService : BaseService<Car, int>, ICarService
{
    private readonly ICarRepository _context;

    public CarService(ICarRepository context) : base(context)
    {
        _context = context;
    }

    //farları ac kapa
}