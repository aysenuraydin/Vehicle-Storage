using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using VehicleStorage.Domain.Common;
using VehicleStorage.Infrastructure;
using VehicleStorage.Infrastructure.Common;
using VehicleStorage.Repository.Domain;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<StorageDbContext>((sp, options) =>
            {
                options.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
                //opt.UseSqlite(configuration.GetConnectionString("DbConnection"), b => b.MigrationsAssembly("Eticaret.API"));
            });

            services.AddScoped(typeof(IRepository<,>), typeof(BaseRepository<,>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IBusRepository, BusRepository>();
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IBoatRepository, BoatRepository>();

            return services;
        }
    }
}