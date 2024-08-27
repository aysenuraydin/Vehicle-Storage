using VehicleStorage.Application.Dtos;
using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Services.Interfaces;

public interface ICarService : IServiceForVehicle<Car, int>
{
    Task<bool> Delete(int id);
    Task<bool> ToggleHeadlight(int id);
}