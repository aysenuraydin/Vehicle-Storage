using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using VehicleStorage.Application.Interfaces;
using VehicleStorage.Domain.Common;
using VehicleStorage.Infrastructure;
using VehicleStorage.Infrastructure.Common;
using VehicleStorage.Repository.Domain;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<StorageDbContext>((sp, options) =>
            {
                options.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped<IStorageDbContext>(provider => provider.GetRequiredService<StorageDbContext>());

            services.AddScoped(typeof(IRepository<,>), typeof(BaseRepository<,>));

            services.AddScoped<IBusRepository, BusRepository>();
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IBoatRepository, BoatRepository>();
            services.AddScoped<IColourRepository, ColourRepository>();
            services.AddScoped<IVehicleRepository, VehicleRepository>();

            return services;
        }
    }
}

//dotnet ef migrations add InitialCreate --project ../VehicleStorage.Infrastructure --startup-project ../VehicleStorage.WebApi 

//dotnet ef database update --project ../VehicleStorage.Infrastructure --startup-project ../VehicleStorage.WebApi 