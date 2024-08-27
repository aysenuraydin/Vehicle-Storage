using VehicleStorage.Domain.Common;
using VehicleStorage.Services;
using VehicleStorage.Services.Interfaces;
namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IService<,>), typeof(BaseService<,>));
        services.AddScoped(typeof(IServiceForVehicle<,>), typeof(VehicleBaseService<,>));

        services.AddTransient<IBusService, BusService>();
        services.AddTransient<ICarService, CarService>();
        services.AddTransient<IBoatService, BoatService>();
        services.AddTransient<IColourService, ColourService>();
        services.AddTransient<IVehicleService, VehicleService>();

        return services;
    }
}