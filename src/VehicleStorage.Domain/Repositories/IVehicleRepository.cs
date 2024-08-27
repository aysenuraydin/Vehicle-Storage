using System.Linq.Expressions;
using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Repository.Domain;

public interface IVehicleRepository : IRepositoryForVehicle<Vehicle, int>
{
    // Task<List<Vehicle>> GetAllIncludeAsync(params Expression<Func<Vehicle, object>>[] tables);
    // Task<List<Vehicle>> GetIdAllIncludeFilterAsync(Expression<Func<Vehicle, bool>> expression, params Expression<Func<Vehicle, object>>[] tables);
}

