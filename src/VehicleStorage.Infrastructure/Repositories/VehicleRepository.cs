using VehicleStorage.Domain.Entities;
using VehicleStorage.Infrastructure;
using VehicleStorage.Infrastructure.Common;

namespace VehicleStorage.Repository.Domain;

public class VehicleRepository : BaseRepository<Vehicle>, IVehicleRepository
{
    private readonly StorageDbContext _context;

    public VehicleRepository(StorageDbContext context) : base(context)
    {
        _context = context;
    }
    //farları ac kapa
}