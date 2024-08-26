using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleStorage.Domain.Common
{
    public interface IService<TEntity, TKey>
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity?> GetById(TKey id);
    }

    public interface IService<TEntity> : IService<TEntity, int>
    {
    }
}