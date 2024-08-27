using VehicleStorage.Application.Interfaces;
using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Repository.Domain;
using VehicleStorage.Services.Interfaces;

namespace VehicleStorage.Services;
public class BoatService : VehicleBaseService<Boat, int>, IBoatService
{
    public BoatService(IColourRepository colourContext, IRepository<Boat, int> repository, IRepositoryForVehicle<Boat, int> serviceForVehicleRepository) : base(colourContext, repository, serviceForVehicleRepository)
    {
    }
}