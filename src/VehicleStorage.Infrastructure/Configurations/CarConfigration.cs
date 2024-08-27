using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Infrastructure.Configurations
{
    public class CarConfigration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable(nameof(Car));

            builder.Property(c => c.Wheels)
                .IsRequired();

            builder.Property(c => c.Headlights)
                .IsRequired();
        }
    }
}