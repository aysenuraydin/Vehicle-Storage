using VehicleStorage.Application.Dtos;

namespace VehicleStorage.Domain.Common
{
    public interface IServiceForVehicle<TEntity, TKey> : IService<TEntity, TKey>
    {
        Task<IEnumerable<VehicleDto>> GetAllByColourNameAsync(string colorName);
    }

    public interface IServiceForVehicle<TEntity> : IService<TEntity, int>
    {

    }
}