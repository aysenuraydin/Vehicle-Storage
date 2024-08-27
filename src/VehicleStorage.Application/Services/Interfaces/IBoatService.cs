using VehicleStorage.Application.Dtos;
using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Services.Interfaces;
public interface IBoatService : IServiceForVehicle<Boat>
{
    Task<IEnumerable<VehicleDto>> GetAllByColourNameAsync(string colorName);
}