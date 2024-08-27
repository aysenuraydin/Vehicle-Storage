using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Domain.Common;
public interface IRepositoryForVehicle<TEntity, TKey> : IRepository<TEntity, TKey>
{
    Task<IEnumerable<TEntity>> GetAllByColourIdAsync(int id);
}