using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VehicleStorage.Domain.Common;

namespace VehicleStorage.Infrastructure.Common;
public class BaseRepository<TEntity, TKey> : IRepository<TEntity, TKey>
where TEntity : class, IEntity<TKey>
{
    private readonly StorageDbContext _context;
    private readonly DbSet<TEntity> _table;
    private bool _disposed;

    public BaseRepository(StorageDbContext context)
    {
        _context = context;
        _table = _context.Set<TEntity>();
    }

    public IQueryable<TEntity> GetAll()
    {
        return default;
    }
    public async Task<TEntity?> GetById(TKey id, bool hasTracking = false)
    {
        return default;
    }

    public Task<TEntity?> GetById(TKey id)
    {
        throw new NotImplementedException();
    }
    public void Dispose()
    {
        //Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        // if (!_disposed)
        // {
        //     if (disposing)
        //     {
        //         _context.Dispose();
        //     }
        // }
        // _disposed = true;
    }
}

public class BaseRepository<TEntity> : BaseRepository<TEntity, int>
     where TEntity : class, IEntity<int>
{
    public BaseRepository(StorageDbContext context) : base(context)
    {
    }
}