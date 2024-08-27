using System.Reflection;
using Microsoft.EntityFrameworkCore;
using VehicleStorage.Application.Interfaces;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Infrastructure
{
    public class StorageDbContext : DbContext, IStorageDbContext
    {

        public DbSet<Colour> Colours { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Boat> Boats { get; set; }

        public StorageDbContext(DbContextOptions<StorageDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//?
        }
    }
}