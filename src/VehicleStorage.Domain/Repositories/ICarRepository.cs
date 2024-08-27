using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Repository.Domain;

public interface ICarRepository : IRepository<Car>
{
    Task<IEnumerable<Car>> GetAllByColourIdAsync(int colorId);
    Task<bool> DeleteById(int id);
    //farları ac kapa
}