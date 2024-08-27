using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Repository.Domain;

public interface IColourRepository : IRepository<Colour, int>
{
    Task<int> GetIdAsync(string colorName);
}