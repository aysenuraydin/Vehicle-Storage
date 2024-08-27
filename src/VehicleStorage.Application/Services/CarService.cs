using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Repository.Domain;
using VehicleStorage.Services.Interfaces;

namespace VehicleStorage.Services;

public class CarService : VehicleBaseService<Car, int>, ICarService
{

    //farları ac kapa
    public CarService(IVehicleRepository vehicleRepository, IColourRepository colourContext, IRepository<Car, int> repository) : base(vehicleRepository, colourContext, repository)
    {
    }
}