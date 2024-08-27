using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Repository.Domain;

public interface IVehicleRepository : IRepositoryForVehicle<Vehicle, int>//kalıtım alıcak mı çünkü farklı ?
{

}