using Microsoft.EntityFrameworkCore;
using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Infrastructure.Common;

public class VehicleBaseRepository<TEntity, TKey> : BaseRepository<TEntity, TKey>, IRepositoryForVehicle<TEntity, TKey>
    where TEntity : class, IVehicle
{
    private readonly StorageDbContext _context;
    private readonly DbSet<TEntity> _table;
    public VehicleBaseRepository(StorageDbContext context) : base(context)
    {
        _context = context;
        _table = _context.Set<TEntity>();
    }
    public async Task<IEnumerable<TEntity>> GetAllByColourIdAsync(int colorId)
    {
        var vehicleList = await _table
                            .Where(x => x.ColourId == colorId)
                            .Include(i => i.ColourFk)
                            .ToListAsync();
        return vehicleList;
    }
}