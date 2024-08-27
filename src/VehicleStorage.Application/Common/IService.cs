using VehicleStorage.Application.Dtos;

namespace VehicleStorage.Domain.Common
{
    public interface IService<TEntity, TKey>
    {
        List<TEntity> GetAll();
        Task<IEnumerable<TEntity>> GetAllAsync();
    }

    public interface IService<TEntity> : IService<TEntity, int>
    {
    }
}