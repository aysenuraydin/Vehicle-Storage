using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Repository.Domain;
using VehicleStorage.Services.Interfaces;

namespace VehicleStorage.Services;

public class CarService : VehicleBaseService<Car, int>, ICarService
{
    ICarRepository _carRepository;
    public CarService(IColourRepository colourContext, IRepository<Car, int> repository, IRepositoryForVehicle<Car, int> serviceForVehicleRepository, ICarRepository carRepository) : base(colourContext, repository, serviceForVehicleRepository)
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
    public async Task<bool> ToggleHeadlight(int id)
    {
        bool isSuccess = await _carRepository.ToggleHeadlight(id);

        if (isSuccess) return true;
        return false;
    }
}