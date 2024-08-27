using VehicleStorage.Application.Dtos;
using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Repository.Domain;
using VehicleStorage.Services.Interfaces;

namespace VehicleStorage.Services;

public class VehicleService : VehicleBaseService<Vehicle, int>, IVehicleService
{
    public VehicleService(IColourRepository colourContext, IRepository<Vehicle, int> repository, IRepositoryForVehicle<Vehicle, int> serviceForVehicleRepository) : base(colourContext, repository, serviceForVehicleRepository)
    {
    }
}