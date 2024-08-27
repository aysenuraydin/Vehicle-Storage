using VehicleStorage.Application.Dtos;
using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Services.Interfaces;

public interface ICarService : IServiceForVehicle<Car>
{
    Task<IEnumerable<VehicleDto>> GetAllByColourNameAsync(string colorName);
    //farları ac kapa
}