using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Domain.Common;
public interface IRepository<TEntity, TKey> : IDisposable
{
    List<TEntity> GetAll();
    Task<IEnumerable<TEntity>> GetAllAsync();
}