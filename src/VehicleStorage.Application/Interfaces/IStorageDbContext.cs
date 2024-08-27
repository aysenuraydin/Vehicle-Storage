using Microsoft.EntityFrameworkCore;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Application.Interfaces
{
    public interface IStorageDbContext
    {
        DbSet<Colour> Colours { get; set; }
        DbSet<Vehicle> Vehicles { get; set; }
        DbSet<Car> Cars { get; set; }
        DbSet<Bus> Buses { get; set; }
        DbSet<Boat> Boats { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}