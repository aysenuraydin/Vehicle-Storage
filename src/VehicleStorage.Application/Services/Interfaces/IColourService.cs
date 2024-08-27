using VehicleStorage.Application.Dtos;
using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Services.Interfaces;
public interface IColourService : IService<Colour>
{
    Task<IEnumerable<ColoursDto>> GetAllColoursAsync();
}