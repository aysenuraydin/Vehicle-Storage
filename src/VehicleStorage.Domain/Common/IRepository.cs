using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleStorage.Domain.Common
{
    public interface IRepository<TEntity, TKey> : IDisposable
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity?> GetById(TKey id);
    }
}