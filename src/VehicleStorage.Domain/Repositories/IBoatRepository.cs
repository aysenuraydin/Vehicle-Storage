using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Repository.Domain;

public interface IBoatRepository : IRepository<Boat>
{
    Task<IEnumerable<Boat>> GetAllByColourIdAsync(int colorId);
}