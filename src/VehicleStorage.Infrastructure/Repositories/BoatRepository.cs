using VehicleStorage.Domain.Entities;
using VehicleStorage.Infrastructure;
using VehicleStorage.Infrastructure.Common;

namespace VehicleStorage.Repository.Domain;

public class BoatRepository : BaseRepository<Boat>, IBoatRepository
{
    private readonly StorageDbContext _context;

    public BoatRepository(StorageDbContext context) : base(context)
    {
        _context = context;
    }
}