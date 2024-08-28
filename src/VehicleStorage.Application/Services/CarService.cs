using VehicleStorage.Application.Dtos;
using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Domain.Enums;
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

    public async Task<CarDto?> ToggleHeadlight(int id)
    {
        Car? car = await _carRepository.ToggleHeadlight(id);

        if (car == null) return null;
        return CarToDTO(car);
    }
    private static CarDto CarToDTO(Car c)
    {
        return new CarDto
        {
            Id = c.Id,
            Name = c.Name,
            CreatedDate = c.CreatedDate.ToString("yyyy-MM-dd"),
            ColourName = c.ColourFk?.ColorName ?? "",
            HeadlightState = c.Headlights == HeadlightStatus.On
        };
    }
}

