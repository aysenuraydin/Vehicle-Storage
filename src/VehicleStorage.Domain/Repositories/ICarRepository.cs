using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Repository.Domain;

public interface ICarRepository : IRepositoryForVehicle<Car, int>
{
    Task<Car?> GetById(int id);
    Task<bool> Delete(Car entity);
    Task<bool> DeleteById(int id);

    //farları ac kapa
    Task<bool> ToggleHeadlight(int id);

}