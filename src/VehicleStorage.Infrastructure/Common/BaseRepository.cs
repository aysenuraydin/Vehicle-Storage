using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Infrastructure.Common;
public class BaseRepository<TEntity, TKey> : IRepository<TEntity, TKey>
where TEntity : class
{
    private readonly StorageDbContext _context;
    private readonly DbSet<TEntity> _table;
    private bool _disposed;

    public BaseRepository(StorageDbContext context)
    {
        _context = context;
        _table = _context.Set<TEntity>();
    }

    public List<TEntity> GetAll()
    {
        return _table.ToList();
    }
    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _table.ToListAsync();
    }

    public List<TEntity> GetAll(Expression<Func<TEntity, bool>> expression)
    {
        return _table.Where(expression).ToList();
    }
    public async Task<IEnumerable<TEntity?>> GetAllAsync(Expression<Func<TEntity, bool>> expression)
    {
        return await _table.Where(expression).ToListAsync();
    }
    public TEntity? Get(Expression<Func<TEntity, bool>> expression)
    {
        return _table.FirstOrDefault(expression)!;
    }
    public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> expression)
    {
        return await _table.FirstOrDefaultAsync(expression);
    }
    public TEntity? Find(int id)
    {
        return _table.Find(id);
    }
    public async Task<TEntity?> FindAsync(int id)
    {
        return await _table.FindAsync(id);
    }
    public int Add(TEntity entity)
    {
        _table.Add(entity);
        return SaveChanges();
    }
    public async Task<int> AddAsync(TEntity entity)
    {
        await _table.AddAsync(entity);
        return SaveChanges();
    }
    public int Update(TEntity entity)
    {
        _context.Update(entity);
        return SaveChanges();
    }
    public async Task<int> UpdateAsync(TEntity entity)
    {
        _context.Update(entity);
        return await SaveChangesAsync();
    }
    public int Delete(TEntity entity)
    {
        _table.Remove(entity);
        return SaveChanges();
    }
    public async Task<bool> DeleteById(int id)
    {
        var entity = await FindAsync(id);

        if (entity != null) return (await DeleteAsync(entity)) > 0;
        return false;
    }
    public async Task<int> DeleteAsync(TEntity entity)
    {
        _table.Remove(entity);
        return await SaveChangesAsync();
    }
    public int SaveChanges()
    {
        return _context.SaveChanges();
    }
    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
        _disposed = true;
    }
}

public class BaseRepository<TEntity> : BaseRepository<TEntity, int>
    where TEntity : class
{
    public BaseRepository(StorageDbContext context) : base(context)
    {
    }
}