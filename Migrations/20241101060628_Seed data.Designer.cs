﻿// <auto-generated />
using System;
using Carrental.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Carrental.WebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241101060628_Seed data")]
    partial class Seeddata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookingConfirmation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<decimal>("DiscountAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalBeforeDiscount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BookingId")
                        .IsUnique();

                    b.ToTable("BookingConfirmations");
                });

            modelBuilder.Entity("Carrental.WebAPI.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("BillingAddress")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<bool>("InsuranceRequired")
                        .HasColumnType("bit");

                    b.Property<string>("LicenseImgPath")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SpecialRequests")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Carrental.WebAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("AltContact")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AltEmail")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("BlockedUntil")
                        .HasColumnType("datetime2");

                    b.Property<string>("ContactNo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DriverLicInfo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("FailedLoginAttempts")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Carrental.WebAPI.Models.Vehicle", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehicleId"));

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Damage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<bool>("Popular")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("VehicleId");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ModelId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Carrental.WebAPI.Models.VehicleBrand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandId"));

                    b.Property<decimal>("RentalCharge")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("VehicleBrandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandId");

                    b.ToTable("VehicleBrands");

                    b.HasData(
                        new
                        {
                            BrandId = 1,
                            RentalCharge = 6000m,
                            VehicleBrandName = "Hyundai"
                        },
                        new
                        {
                            BrandId = 2,
                            RentalCharge = 5100m,
                            VehicleBrandName = "Suzuki"
                        },
                        new
                        {
                            BrandId = 3,
                            RentalCharge = 7500m,
                            VehicleBrandName = "Toyota"
                        },
                        new
                        {
                            BrandId = 4,
                            RentalCharge = 7000m,
                            VehicleBrandName = "Honda"
                        },
                        new
                        {
                            BrandId = 5,
                            RentalCharge = 5500m,
                            VehicleBrandName = "Tata Motors"
                        },
                        new
                        {
                            BrandId = 6,
                            RentalCharge = 4000m,
                            VehicleBrandName = "Ashok Leyland"
                        },
                        new
                        {
                            BrandId = 7,
                            RentalCharge = 4800m,
                            VehicleBrandName = "Mahindra"
                        },
                        new
                        {
                            BrandId = 8,
                            RentalCharge = 5000m,
                            VehicleBrandName = "Eicher"
                        });
                });

            modelBuilder.Entity("Carrental.WebAPI.Models.VehicleCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("VehicleCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("VehicleCategories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            VehicleCategoryName = "Car"
                        },
                        new
                        {
                            CategoryId = 2,
                            VehicleCategoryName = "Bus"
                        },
                        new
                        {
                            CategoryId = 3,
                            VehicleCategoryName = "Sumo"
                        },
                        new
                        {
                            CategoryId = 4,
                            VehicleCategoryName = "Truck"
                        },
                        new
                        {
                            CategoryId = 5,
                            VehicleCategoryName = "Minivan"
                        },
                        new
                        {
                            CategoryId = 6,
                            VehicleCategoryName = "Jeep"
                        },
                        new
                        {
                            CategoryId = 7,
                            VehicleCategoryName = "Microbus"
                        },
                        new
                        {
                            CategoryId = 8,
                            VehicleCategoryName = "Tempo"
                        },
                        new
                        {
                            CategoryId = 9,
                            VehicleCategoryName = "Van"
                        },
                        new
                        {
                            CategoryId = 10,
                            VehicleCategoryName = "Scooter"
                        },
                        new
                        {
                            CategoryId = 11,
                            VehicleCategoryName = "Cycle"
                        },
                        new
                        {
                            CategoryId = 12,
                            VehicleCategoryName = "Bike"
                        },
                        new
                        {
                            CategoryId = 13,
                            VehicleCategoryName = "Scorpio"
                        });
                });

            modelBuilder.Entity("Carrental.WebAPI.Models.VehicleImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("VehicleImages");
                });

            modelBuilder.Entity("Carrental.WebAPI.Models.VehicleModel", b =>
                {
                    b.Property<int>("ModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ModelId"));

                    b.Property<string>("VehicleModelName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModelId");

                    b.ToTable("VehicleModels");

                    b.HasData(
                        new
                        {
                            ModelId = 1,
                            VehicleModelName = "i10"
                        },
                        new
                        {
                            ModelId = 2,
                            VehicleModelName = "i20"
                        },
                        new
                        {
                            ModelId = 3,
                            VehicleModelName = "Creta"
                        },
                        new
                        {
                            ModelId = 4,
                            VehicleModelName = "Santro"
                        },
                        new
                        {
                            ModelId = 5,
                            VehicleModelName = "Alto"
                        },
                        new
                        {
                            ModelId = 6,
                            VehicleModelName = "Swift"
                        },
                        new
                        {
                            ModelId = 7,
                            VehicleModelName = "WagonR"
                        },
                        new
                        {
                            ModelId = 8,
                            VehicleModelName = "Celerio"
                        },
                        new
                        {
                            ModelId = 9,
                            VehicleModelName = "Corolla"
                        },
                        new
                        {
                            ModelId = 10,
                            VehicleModelName = "Yaris"
                        },
                        new
                        {
                            ModelId = 11,
                            VehicleModelName = "Vitz"
                        },
                        new
                        {
                            ModelId = 12,
                            VehicleModelName = "City"
                        },
                        new
                        {
                            ModelId = 13,
                            VehicleModelName = "Amaze"
                        },
                        new
                        {
                            ModelId = 14,
                            VehicleModelName = "Jazz"
                        },
                        new
                        {
                            ModelId = 15,
                            VehicleModelName = "Tiago"
                        },
                        new
                        {
                            ModelId = 16,
                            VehicleModelName = "Nexon"
                        },
                        new
                        {
                            ModelId = 17,
                            VehicleModelName = "Tigor"
                        },
                        new
                        {
                            ModelId = 18,
                            VehicleModelName = "LP 407"
                        },
                        new
                        {
                            ModelId = 19,
                            VehicleModelName = "LP 1512"
                        },
                        new
                        {
                            ModelId = 20,
                            VehicleModelName = "Viking"
                        },
                        new
                        {
                            ModelId = 21,
                            VehicleModelName = "Cheetah"
                        },
                        new
                        {
                            ModelId = 22,
                            VehicleModelName = "Cruzio"
                        },
                        new
                        {
                            ModelId = 23,
                            VehicleModelName = "Supro Bus"
                        },
                        new
                        {
                            ModelId = 24,
                            VehicleModelName = "Skyline"
                        },
                        new
                        {
                            ModelId = 25,
                            VehicleModelName = "Starline"
                        },
                        new
                        {
                            ModelId = 26,
                            VehicleModelName = "Sumo Gold"
                        },
                        new
                        {
                            ModelId = 27,
                            VehicleModelName = "Sumo Victa"
                        },
                        new
                        {
                            ModelId = 28,
                            VehicleModelName = "Bolero"
                        },
                        new
                        {
                            ModelId = 29,
                            VehicleModelName = "Scorpio"
                        },
                        new
                        {
                            ModelId = 30,
                            VehicleModelName = "Blazo"
                        },
                        new
                        {
                            ModelId = 31,
                            VehicleModelName = "Furio"
                        },
                        new
                        {
                            ModelId = 32,
                            VehicleModelName = "Pro 3015"
                        },
                        new
                        {
                            ModelId = 33,
                            VehicleModelName = "Pro 2049"
                        },
                        new
                        {
                            ModelId = 34,
                            VehicleModelName = "Dost+"
                        },
                        new
                        {
                            ModelId = 35,
                            VehicleModelName = "2516 IL"
                        },
                        new
                        {
                            ModelId = 36,
                            VehicleModelName = "Eeco"
                        },
                        new
                        {
                            ModelId = 37,
                            VehicleModelName = "Omni"
                        },
                        new
                        {
                            ModelId = 38,
                            VehicleModelName = "Venture"
                        },
                        new
                        {
                            ModelId = 39,
                            VehicleModelName = "Winger"
                        },
                        new
                        {
                            ModelId = 40,
                            VehicleModelName = "Supro Van"
                        },
                        new
                        {
                            ModelId = 41,
                            VehicleModelName = "Bolero Camper"
                        });
                });

            modelBuilder.Entity("BookingConfirmation", b =>
                {
                    b.HasOne("Carrental.WebAPI.Models.Booking", "Booking")
                        .WithOne("BookingConfirmation")
                        .HasForeignKey("BookingConfirmation", "BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("Carrental.WebAPI.Models.Booking", b =>
                {
                    b.HasOne("Carrental.WebAPI.Models.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("Carrental.WebAPI.Models.Vehicle", b =>
                {
                    b.HasOne("Carrental.WebAPI.Models.VehicleBrand", "Brand")
                        .WithMany("Vehicles")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Carrental.WebAPI.Models.VehicleCategory", "Category")
                        .WithMany("Vehicles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Carrental.WebAPI.Models.VehicleModel", "Model")
                        .WithMany("Vehicles")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");

                    b.Navigation("Model");
                });

            modelBuilder.Entity("Carrental.WebAPI.Models.VehicleImage", b =>
                {
                    b.HasOne("Carrental.WebAPI.Models.Vehicle", "Vehicle")
                        .WithMany("VehicleImages")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("Carrental.WebAPI.Models.Booking", b =>
                {
                    b.Navigation("BookingConfirmation");
                });

            modelBuilder.Entity("Carrental.WebAPI.Models.Vehicle", b =>
                {
                    b.Navigation("VehicleImages");
                });

            modelBuilder.Entity("Carrental.WebAPI.Models.VehicleBrand", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Carrental.WebAPI.Models.VehicleCategory", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Carrental.WebAPI.Models.VehicleModel", b =>
                {
                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
