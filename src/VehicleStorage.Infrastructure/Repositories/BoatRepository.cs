using Microsoft.EntityFrameworkCore;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Infrastructure;
using VehicleStorage.Infrastructure.Common;

namespace VehicleStorage.Repository.Domain;

public class BoatRepository : VehicleBaseRepository<Boat, int>, IBoatRepository
{
    public BoatRepository(StorageDbContext context) : base(context)
    {
    }
}