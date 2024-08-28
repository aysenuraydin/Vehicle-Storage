
namespace VehicleStorage.Domain.Common
{
    public class BaseService<TEntity, TKey> : IService<TEntity, TKey>
    where TEntity : class
    {
        private readonly IRepository<TEntity, TKey> _repository;

        public BaseService(IRepository<TEntity, TKey> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        /*
        public async Task<TEntity?> GetById(TKey id)
        {
            return await _repository.FindAsync(id);
        }
        public async Task Create(TEntity entity)
        {
            await _repository.AddAsync(entity);
            return;
        }
        public async Task Update(TEntity entity)
        {
            await _repository.UpdateAsync(entity);
            return;
        }
        public async Task Delete(TEntity entity)
        {
            await _repository.DeleteAsync(entity);
            return;
        }
        */

    }
}