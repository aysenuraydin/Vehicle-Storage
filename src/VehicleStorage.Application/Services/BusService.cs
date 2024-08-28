using AutoMapper;
using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Repository.Domain;
using VehicleStorage.Services.Interfaces;

namespace VehicleStorage.Services;

public class BusService : VehicleBaseService<Bus, int>, IBusService
{
    public BusService(IColourRepository colourContext, IRepository<Bus, int> repository, IRepositoryForVehicle<Bus, int> serviceForVehicleRepository, IMapper mapper) : base(colourContext, repository, serviceForVehicleRepository, mapper)
    {
    }
}