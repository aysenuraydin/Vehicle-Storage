using Microsoft.EntityFrameworkCore;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Infrastructure;
using VehicleStorage.Infrastructure.Common;

namespace VehicleStorage.Repository.Domain;

public class CarRepository : BaseRepository<Car>, ICarRepository
{
    private readonly StorageDbContext _context;
    private readonly DbSet<Car> _table;
    public CarRepository(StorageDbContext context) : base(context)
    {
        _context = context;
        _table = _context.Set<Car>();
    }

    public async Task<bool> Delete(Car entity)
    {
        _table.Remove(entity);
        int affected = await _context.SaveChangesAsync();
        return affected > 0;
    }

    public async Task<bool> DeleteById(int id)
    {
        var entity = await _table.FindAsync(id);
        if (entity != null) return await Delete(entity);
        return false;
    }
    public async Task<IEnumerable<Car>> GetAllByColourIdAsync(int colorId)
    {
        var vehicleList = await _table
                            .Where(x => x.ColourId == colorId)
                            .Include(i => i.ColourFk)
                            .ToListAsync();
        return vehicleList;
    }


    //farları ac kapa
}