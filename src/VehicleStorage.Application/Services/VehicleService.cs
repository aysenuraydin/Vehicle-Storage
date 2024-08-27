using VehicleStorage.Application.Dtos;
using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Repository.Domain;
using VehicleStorage.Services.Interfaces;

namespace VehicleStorage.Services;

public class VehicleService : VehicleBaseService<Vehicle, int>, IVehicleService
{
    public VehicleService(IVehicleRepository vehicleRepository, IColourRepository colourContext, IRepository<Vehicle, int> repository) : base(vehicleRepository, colourContext, repository)
    {
    }
}