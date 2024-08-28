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
    public async Task<Car?> ToggleHeadlight(int id)
    {
        var entity = await GetIncludeFilterAsync(
                        x => x.Id == id,
                        x => x.ColourFk
                    );
        //include yapmalısın firstordefault ile

        if (entity == null) return null;

        entity.Headlights = (entity.Headlights == HeadlightStatus.On)
                                ? HeadlightStatus.Off
                                : HeadlightStatus.On;

        _table.Update(entity);
        await SaveChangesAsync();

        return entity;
    }
}