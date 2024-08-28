using System.Linq.Expressions;

namespace VehicleStorage.Domain.Common;
public interface IRepositoryForVehicle<TEntity, TKey> : IRepository<TEntity, TKey>
{
    Task<IEnumerable<TEntity>> GetAllByColourIdAsync(int id);
    Task<List<TEntity>> GetAllIncludeAsync(params Expression<Func<TEntity, object>>[] tables);
    Task<List<TEntity>> GetAllIncludeFilterAsync(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] tables);
    Task<TEntity?> GetIncludeFilterAsync(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] tables);

}


