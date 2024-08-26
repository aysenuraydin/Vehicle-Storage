using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using VehicleStorage.Domain.Entities;
using VehicleStorage.Infrastructure.Common;

namespace VehicleStorage.Infrastructure.Seeders
{
    public class VehicleSeeder : ISeeder
    {
        public async Task Seed(StorageDbContext context)
        {
            if (context.Cars.Any()) return;

            var trSet = new Bogus.DataSets.Company(locale: "tr");

            var faker = new Faker<Car>()
                .RuleFor(e => e.Name, c => trSet.CompanyName())
            //... Devamını yaz.
            ;


            var list = faker.Generate(20);

            await context.Cars.AddRangeAsync(list);
            await context.SaveChangesAsync();
        }
    }
}