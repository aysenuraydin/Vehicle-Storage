using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Infrastructure.Configurations
{
    public class BoatConfigration : IEntityTypeConfiguration<Boat>
    {
        public void Configure(EntityTypeBuilder<Boat> builder)
        {
            builder.ToTable(nameof(Boat));
        }
    }


}