using System.Drawing;
using Microsoft.EntityFrameworkCore;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Application.Interfaces
{
    public interface IStorageDbContext
    {
        DbSet<Colour> Colours { get; }
        DbSet<Vehicle> Vehicles { get; }
        DbSet<Car> Cars { get; }
        DbSet<Bus> Buses { get; }
        DbSet<Boat> Boats { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}