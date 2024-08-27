using VehicleStorage.Domain.Entities;
using VehicleStorage.Infrastructure.Common;

namespace VehicleStorage.Infrastructure.Seeders
{
    public class ColourSeeder : ISeeder
    {
        public async Task Seed(StorageDbContext context)
        {
            if (context.Colours.Any()) return;

            var colors = new List<Colour>() {
                new() { Id=1, ColorName="Beyaz"},
                new() { Id=2, ColorName="Kırmızı"},
                new() { Id=3, ColorName="Siyah"},
                new() { Id=4, ColorName="Mavi"},
                new() { Id=5, ColorName="Gri"}
            };

            await context.Colours.AddRangeAsync(colors);
            await context.SaveChangesAsync();
        }
    }
}