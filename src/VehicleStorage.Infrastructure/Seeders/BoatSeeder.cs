using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

            var trSet = new Bogus.DataSets.Company(locale: "tr");

            var faker = new Faker<Boat>()
                .RuleFor(e => e.Name, c => trSet.CompanyName())
            //... Devamını yaz.
            ;


            var list = faker.Generate(20);

            await context.Boats.AddRangeAsync(list);
            await context.SaveChangesAsync();
        }
    }
}