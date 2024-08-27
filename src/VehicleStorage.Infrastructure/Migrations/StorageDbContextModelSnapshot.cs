﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicleStorage.Infrastructure;

#nullable disable

namespace VehicleStorage.Infrastructure.Migrations
{
    [DbContext(typeof(StorageDbContext))]
    partial class StorageDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("VehicleStorage.Domain.Entities.Colour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ColorName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Colour", (string)null);
                });

            modelBuilder.Entity("VehicleStorage.Domain.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ColourId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ColourId");

                    b.ToTable("Vehicle", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("VehicleStorage.Domain.Entities.Boat", b =>
                {
                    b.HasBaseType("VehicleStorage.Domain.Entities.Vehicle");

                    b.ToTable("Boat", (string)null);
                });

            modelBuilder.Entity("VehicleStorage.Domain.Entities.Bus", b =>
                {
                    b.HasBaseType("VehicleStorage.Domain.Entities.Vehicle");

                    b.ToTable("Bus", (string)null);
                });

            modelBuilder.Entity("VehicleStorage.Domain.Entities.Car", b =>
                {
                    b.HasBaseType("VehicleStorage.Domain.Entities.Vehicle");

                    b.Property<int>("Headlights")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Wheels")
                        .HasColumnType("INTEGER");

                    b.ToTable("Car", (string)null);
                });

            modelBuilder.Entity("VehicleStorage.Domain.Entities.Vehicle", b =>
                {
                    b.HasOne("VehicleStorage.Domain.Entities.Colour", "ColourFk")
                        .WithMany("Products")
                        .HasForeignKey("ColourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ColourFk");
                });

            modelBuilder.Entity("VehicleStorage.Domain.Entities.Boat", b =>
                {
                    b.HasOne("VehicleStorage.Domain.Entities.Vehicle", null)
                        .WithOne()
                        .HasForeignKey("VehicleStorage.Domain.Entities.Boat", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VehicleStorage.Domain.Entities.Bus", b =>
                {
                    b.HasOne("VehicleStorage.Domain.Entities.Vehicle", null)
                        .WithOne()
                        .HasForeignKey("VehicleStorage.Domain.Entities.Bus", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VehicleStorage.Domain.Entities.Car", b =>
                {
                    b.HasOne("VehicleStorage.Domain.Entities.Vehicle", null)
                        .WithOne()
                        .HasForeignKey("VehicleStorage.Domain.Entities.Car", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VehicleStorage.Domain.Entities.Colour", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
