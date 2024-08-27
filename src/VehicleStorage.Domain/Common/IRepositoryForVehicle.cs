using System.Linq.Expressions;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Domain.Common;
public interface IRepositoryForVehicle<TEntity, TKey> : IRepository<TEntity, TKey>
{
    Task<IEnumerable<TEntity>> GetAllByColourIdAsync(int id);
    Task<List<TEntity>> GetAllIncludeAsync(params Expression<Func<TEntity, object>>[] tables);
    Task<List<TEntity>> GetIdAllIncludeFilterAsync(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] tables);
}