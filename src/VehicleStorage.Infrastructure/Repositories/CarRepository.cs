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
    public async Task<Car?> GetById(int id)
    {
        var entity = await _table.FindAsync(id);

        if (entity != null) return entity;
        return default;
    }
    public async Task<bool> ToggleHeadlight(int id)
    {
        var entity = await GetById(id);

        if (entity == null) return default;

        entity.Headlights = (entity.Headlights == HeadlightStatus.On)
                                ? HeadlightStatus.Off
                                : HeadlightStatus.On;

        await _context.SaveChangesAsync();

        return entity.Headlights == HeadlightStatus.On; ;
    }

    public async Task<bool> Delete(Car entity)
    {
        _table.Remove(entity);
        int affected = await _context.SaveChangesAsync();
        return affected > 0;
    }

    public async Task<bool> DeleteById(int id)
    {
        var entity = await GetById(id);

        if (entity != null) return await Delete(entity);
        return false;
    }
}