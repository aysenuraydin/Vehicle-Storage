using VehicleStorage.Domain.Entities;
using VehicleStorage.Infrastructure;
using VehicleStorage.Infrastructure.Common;

namespace VehicleStorage.Repository.Domain;

public class VehicleRepository : VehicleBaseRepository<Vehicle, int>, IVehicleRepository
{
    public VehicleRepository(StorageDbContext context) : base(context)
    {
    }
}