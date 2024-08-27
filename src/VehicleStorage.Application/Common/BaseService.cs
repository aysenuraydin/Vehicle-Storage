
using VehicleStorage.Application.Dtos;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Repository.Domain;

namespace VehicleStorage.Domain.Common
{
    public class BaseService<TEntity, TKey> : IService<TEntity, TKey>
    where TEntity : class, IEntity<TKey>
    {
        private readonly IRepository<TEntity, TKey> _repository;

        public BaseService(IRepository<TEntity, TKey> repository)
        {
            _repository = repository;
        }

        public List<TEntity> GetAll()
        {
            return _repository.GetAll();
        }
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }
    }
}