using Bogus;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Infrastructure.Common;

namespace VehicleStorage.Infrastructure.Seeders
{
    public class BoatSeeder : ISeeder
    {
        public async Task Seed(StorageDbContext context)
        {
            if (context.Boats.Any()) return;

            var random = new Random();

            var faker = new Faker<Boat>()
                .RuleFor(e => e.Name, f => $"Boat Name {f.IndexFaker + 1}")
                .RuleFor(e => e.ColourId, _ => random.Next(1, 5));
            //... Devamını yaz.

            var list = faker.Generate(10);

            await context.Boats.AddRangeAsync(list);
            await context.SaveChangesAsync();
        }
    }
}