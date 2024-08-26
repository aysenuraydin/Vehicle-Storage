using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Repository.Domain;

public interface ICarRepository : IRepository<Car, long>
{

}