using Microsoft.EntityFrameworkCore;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Domain.Enums;
using VehicleStorage.Infrastructure;
using VehicleStorage.Infrastructure.Common;

namespace VehicleStorage.Repository.Domain;

public class CarRepository : VehicleBaseRepository<Car, int>, ICarRepository
{
    private readonly StorageDbContext _context;
    private readonly DbSet<Car> _table;
    public CarRepository(StorageDbContext context) : base(context)
    {
        _context = context;
        _table = _context.Set<Car>();
    }
    public async Task<bool> ToggleHeadlight(int id)
    {
        var entity = await FindAsync(id);

        if (entity == null) return default;

        entity.Headlights = (entity.Headlights == HeadlightStatus.On)
                                ? HeadlightStatus.Off
                                : HeadlightStatus.On;

        await SaveChangesAsync();

        return entity.Headlights == HeadlightStatus.On; ;
    }
}