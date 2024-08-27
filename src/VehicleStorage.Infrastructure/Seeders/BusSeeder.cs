using Bogus;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Infrastructure.Common;

namespace VehicleStorage.Infrastructure.Seeders
{
    public class BusSeeder : ISeeder
    {
        public async Task Seed(StorageDbContext context)
        {
            if (context.Buses.Any()) return;

            var random = new Random();

            var faker = new Faker<Bus>()
                .RuleFor(e => e.Name, f => $"Bus Name {f.IndexFaker + 1}")
                .RuleFor(e => e.ColourId, _ => random.Next(1, 5))
            //... Devamını yaz.
            ;

            var list = faker.Generate(10);

            await context.Buses.AddRangeAsync(list);
            await context.SaveChangesAsync();
        }
    }
}