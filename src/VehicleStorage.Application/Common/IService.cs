namespace VehicleStorage.Domain.Common
{
    public interface IService<TEntity, TKey>
    {
        Task<IEnumerable<TEntity>> GetAll();
        // Task<TEntity?> GetById(TKey id);
        // Task Create(TEntity entity);
        // Task Update(TEntity entity);
        // Task Delete(TEntity entity);
    }

    public interface IService<TEntity> : IService<TEntity, int>
    {
    }
}