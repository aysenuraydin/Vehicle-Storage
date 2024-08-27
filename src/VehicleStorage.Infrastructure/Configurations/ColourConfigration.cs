using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Infrastructure.Configurations
{
    public class ColorConfigration : IEntityTypeConfiguration<Colour>
    {
        public void Configure(EntityTypeBuilder<Colour> builder)
        {
            builder.ToTable(nameof(Colour));
            builder.HasKey(c => c.Id);

            builder
                .Property(b => b.ColorName)
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}