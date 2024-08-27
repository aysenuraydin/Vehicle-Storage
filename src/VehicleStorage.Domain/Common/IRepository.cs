namespace VehicleStorage.Domain.Common;
public interface IRepository<TEntity, TKey> : IDisposable
{
    List<TEntity> GetAll();
    Task<IEnumerable<TEntity>> GetAllAsync();
}
public interface IRepository<TEntity> : IRepository<TEntity, int>
{
}