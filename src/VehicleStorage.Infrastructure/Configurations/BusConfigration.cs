using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Infrastructure.Configurations
{
    public class BusConfigration : IEntityTypeConfiguration<Bus>
    {
        public void Configure(EntityTypeBuilder<Bus> builder)
        {
            builder.ToTable(nameof(Bus));
        }
    }
}