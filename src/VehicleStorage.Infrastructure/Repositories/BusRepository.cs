using VehicleStorage.Domain.Entities;
using VehicleStorage.Infrastructure;
using VehicleStorage.Infrastructure.Common;

namespace VehicleStorage.Repository.Domain;

public class BusRepository : VehicleBaseRepository<Bus, int>, IBusRepository
{
    public BusRepository(StorageDbContext context) : base(context)
    {
    }
}