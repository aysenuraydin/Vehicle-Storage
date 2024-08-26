using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleStorage.Domain.Common;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Infrastructure.Common
{
    public class VehicleConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
    where TEntity : Vehicle
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.ToTable(typeof(TEntity).Name, "dbo");

            builder.Property(b => b.Id).IsRequired();
            builder.Property(b => b.Name).HasMaxLength(150).IsRequired();
            //...
        }

    }
}