namespace VehicleStorage.Domain.Common;
public interface IRepository<TEntity, TKey> : IDisposable
{
    List<TEntity> GetAll();
    Task<IEnumerable<TEntity>> GetAllAsync();
    // Task<IEnumerable<TEntity>> GetAllByColourAsync(string colorName);
}
public interface IRepository<TEntity> : IRepository<TEntity, int>
{
}