using Bogus;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Domain.Enums;
using VehicleStorage.Infrastructure.Common;

namespace VehicleStorage.Infrastructure.Seeders
{
    public class CarSeeder : ISeeder
    {
        public async Task Seed(StorageDbContext context)
        {
            if (context.Cars.Any()) return;

            var random = new Random();

            var faker = new Faker<Car>()
                .RuleFor(e => e.Name, f => $"Car Name {f.IndexFaker + 1}")
                .RuleFor(e => e.ColourId, _ => random.Next(1, 5))
                .RuleFor(c => c.Wheels, f => f.Random.Int(4, 6))
                .RuleFor(c => c.Headlights, f => f.PickRandom<HeadlightStatus>());
            ;

            var list = faker.Generate(10);

            await context.Cars.AddRangeAsync(list);
            await context.SaveChangesAsync();
        }
    }
}