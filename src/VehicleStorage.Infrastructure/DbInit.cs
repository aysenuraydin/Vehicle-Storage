using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using VehicleStorage.Infrastructure.Common;
using VehicleStorage.Infrastructure.Seeders;

namespace VehicleStorage.Infrastructure;
public static class DbInitExtensions
{
    public static async Task InitializeDb(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<StorageDbContext>();

        //context.Database.EnsureDeleted();
        //context.Database.EnsureCreated();

        // Migration yapısını kullandığımız durumda proje çalıştığında Migration işlemini yapar.
        context.Database.Migrate();

        await new ColourSeeder().Seed(context);
        await new BoatSeeder().Seed(context);
        await new BusSeeder().Seed(context);
        await new CarSeeder().Seed(context);

        await ApplyAllSeederFromAssembly(context);
    }

    private static async Task ApplyAllSeederFromAssembly(StorageDbContext context)
    {
        var seederType = typeof(ISeeder);
        var seeders = Assembly.GetExecutingAssembly().GetTypes()
            .Where(s => seederType.IsAssignableFrom(s) && s != seederType)
            .ToList();
        foreach (var type in seeders)
        {
            try
            {
                var seeder = Activator.CreateInstance(type) as ISeeder;
                await seeder?.Seed(context);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}