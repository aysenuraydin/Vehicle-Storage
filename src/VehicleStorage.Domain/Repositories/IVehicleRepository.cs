using System.Linq.Expressions;
using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Repository.Domain;

public interface IVehicleRepository : IRepositoryForVehicle<Vehicle, int>
{

}

