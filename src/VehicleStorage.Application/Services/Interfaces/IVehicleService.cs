using VehicleStorage.Application.Dtos;
using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Services.Interfaces;
public interface IVehicleService : IServiceForVehicle<Vehicle>
{
    Task<IEnumerable<VehicleDto>> GetAllByColourNameAsync(string colorName);
}