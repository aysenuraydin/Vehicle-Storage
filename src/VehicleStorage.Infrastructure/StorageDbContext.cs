using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VehicleStorage.Application.Interfaces;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Infrastructure
{
    public class StorageDbContext : DbContext, IStorageDbContext
    {

        public DbSet<Colour> Colours { get; set; }
        public DbSet<Vehicle> Vehicles { get; }
        public DbSet<Car> Cars { get; }
        public DbSet<Bus> Buses { get; }
        public DbSet<Boat> Boats { get; }
        //Dbset ...

        public StorageDbContext(DbContextOptions<StorageDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//?
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);//?
        }
        //konfigure etmek için hangisi ?
    }
}