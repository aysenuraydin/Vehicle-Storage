

namespace VehicleStorage.Domain.Common
{
    public class BaseService<TEntity, TKey> : IService<TEntity, TKey>
    where TEntity : class, IEntity<TKey>
    {
        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity?> GetById(TKey id)
        {
            throw new NotImplementedException();
        }
    }
}