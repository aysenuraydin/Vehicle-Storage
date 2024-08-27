using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Repository.Domain;

public interface IVehicleRepository : IRepository<Vehicle>//kalıtım alıcak mı çünkü farklı ?
{
    Task<IEnumerable<Vehicle>> GetAllByColourIdAsync(int colorId);
}