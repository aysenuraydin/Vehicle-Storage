using VehicleStorage.Domain.Entities;
using VehicleStorage.Infrastructure;
using VehicleStorage.Infrastructure.Common;

namespace VehicleStorage.Repository.Domain;

public class CarRepository : BaseRepository<Car>, ICarRepository
{
    private readonly StorageDbContext _context;

    public CarRepository(StorageDbContext context) : base(context)
    {
        _context = context;
    }
    //farları ac kapa
}