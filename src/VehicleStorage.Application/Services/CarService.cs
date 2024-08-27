using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Repository.Domain;
using VehicleStorage.Services.Interfaces;

namespace VehicleStorage.Services;

public class CarService : VehicleBaseService<Car, int>, ICarService
{

    ICarRepository _carRepository;
    //farları ac kapa
    public CarService(IVehicleRepository vehicleRepository, IColourRepository colourContext, IRepository<Car, int> repository, ICarRepository carRepository) : base(vehicleRepository, colourContext, repository)
    {
        _carRepository = carRepository;

    }
    public async Task<bool> Delete(int id)
    {
        bool isSuccess = await _carRepository.DeleteById(id);
        if (isSuccess)
            return true;
        return false;
    }
}