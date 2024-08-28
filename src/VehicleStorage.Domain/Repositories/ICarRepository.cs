using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Repository.Domain;

public interface ICarRepository : IRepositoryForVehicle<Car, int>
{
    Task<Car?> ToggleHeadlight(int id);
}