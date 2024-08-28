using AutoMapper;
using VehicleStorage.Application.Dtos;
using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Domain.Enums;
using VehicleStorage.Repository.Domain;
using VehicleStorage.Services.Interfaces;

namespace VehicleStorage.Services;

public class CarService : VehicleBaseService<Car, int>, ICarService
{
    IMapper _mapper;
    ICarRepository _carRepository;
    public CarService(IColourRepository colourContext, IRepository<Car, int> repository, IRepositoryForVehicle<Car, int> serviceForVehicleRepository, ICarRepository carRepository, IMapper mapper) : base(colourContext, repository, serviceForVehicleRepository, mapper)
    {
        _carRepository = carRepository;
        _mapper = mapper;
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
        return _mapper.Map<CarDto>(car);
    }
}

