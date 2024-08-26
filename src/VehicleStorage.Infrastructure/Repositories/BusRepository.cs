using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Infrastructure;
using VehicleStorage.Infrastructure.Common;

namespace VehicleStorage.Repository.Domain;

public class BusRepository : BaseRepository<Bus>, IBusRepository
{
    private readonly StorageDbContext _context;

    public BusRepository(StorageDbContext context) : base(context)
    {
        _context = context;
    }
}