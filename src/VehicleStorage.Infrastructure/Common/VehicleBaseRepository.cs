using System.Linq.Expressions;
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
    public async Task<List<TEntity>> GetAllIncludeAsync(params Expression<Func<TEntity, object>>[] tables)
    {
        IQueryable<TEntity> db = _table;
        foreach (var table in tables)
        {
            db = db.Include(table);
        }
        return await db.ToListAsync();
    }
    public async Task<List<TEntity>> GetIdAllIncludeFilterAsync(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] tables)
    {
        IQueryable<TEntity> db = _table;
        foreach (var table in tables)
        {
            db = db.Include(table);
        }
        return await db.Where(expression).ToListAsync();
    }
}