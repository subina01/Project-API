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
    [Migration("20241101044704_Dynamic Pricing")]
    partial class DynamicPricing
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
                            RentalCharge = 5000m,
                            VehicleBrandName = "Maruti Suzuki"
                        },
                        new
                        {
                            BrandId = 2,
                            RentalCharge = 6000m,
                            VehicleBrandName = "Hyundai"
                        },
                        new
                        {
                            BrandId = 3,
                            RentalCharge = 5500m,
                            VehicleBrandName = "Tata Motors"
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
                            RentalCharge = 7500m,
                            VehicleBrandName = "Toyota"
                        },
                        new
                        {
                            BrandId = 6,
                            RentalCharge = 6500m,
                            VehicleBrandName = "Ford"
                        },
                        new
                        {
                            BrandId = 7,
                            RentalCharge = 6200m,
                            VehicleBrandName = "Nissan"
                        },
                        new
                        {
                            BrandId = 8,
                            RentalCharge = 4800m,
                            VehicleBrandName = "Mahindra"
                        },
                        new
                        {
                            BrandId = 9,
                            RentalCharge = 5100m,
                            VehicleBrandName = "Suzuki"
                        },
                        new
                        {
                            BrandId = 10,
                            RentalCharge = 8000m,
                            VehicleBrandName = "Isuzu"
                        },
                        new
                        {
                            BrandId = 11,
                            RentalCharge = 3000m,
                            VehicleBrandName = "KTM"
                        },
                        new
                        {
                            BrandId = 12,
                            RentalCharge = 2800m,
                            VehicleBrandName = "Bajaj"
                        },
                        new
                        {
                            BrandId = 13,
                            RentalCharge = 2900m,
                            VehicleBrandName = "Yamaha"
                        },
                        new
                        {
                            BrandId = 14,
                            RentalCharge = 3500m,
                            VehicleBrandName = "Royal Enfield"
                        },
                        new
                        {
                            BrandId = 15,
                            RentalCharge = 4000m,
                            VehicleBrandName = "Ashok Leyland"
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
                            VehicleCategoryName = "Jeep"
                        },
                        new
                        {
                            CategoryId = 4,
                            VehicleCategoryName = "Truck"
                        },
                        new
                        {
                            CategoryId = 5,
                            VehicleCategoryName = "Motorbike"
                        },
                        new
                        {
                            CategoryId = 6,
                            VehicleCategoryName = "Scooter"
                        },
                        new
                        {
                            CategoryId = 7,
                            VehicleCategoryName = "Minivan"
                        },
                        new
                        {
                            CategoryId = 8,
                            VehicleCategoryName = "Pickup"
                        },
                        new
                        {
                            CategoryId = 9,
                            VehicleCategoryName = "Tractor"
                        },
                        new
                        {
                            CategoryId = 10,
                            VehicleCategoryName = "Microbus"
                        },
                        new
                        {
                            CategoryId = 11,
                            VehicleCategoryName = "Tempo"
                        },
                        new
                        {
                            CategoryId = 12,
                            VehicleCategoryName = "Electric Rickshaw"
                        },
                        new
                        {
                            CategoryId = 13,
                            VehicleCategoryName = "Bicycle"
                        },
                        new
                        {
                            CategoryId = 14,
                            VehicleCategoryName = "SUV"
                        },
                        new
                        {
                            CategoryId = 15,
                            VehicleCategoryName = "Van"
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
                            VehicleModelName = "Maruti Suzuki Alto"
                        },
                        new
                        {
                            ModelId = 2,
                            VehicleModelName = "Hyundai i20"
                        },
                        new
                        {
                            ModelId = 3,
                            VehicleModelName = "Tata Nexon"
                        },
                        new
                        {
                            ModelId = 4,
                            VehicleModelName = "Honda City"
                        },
                        new
                        {
                            ModelId = 5,
                            VehicleModelName = "Toyota Corolla"
                        },
                        new
                        {
                            ModelId = 6,
                            VehicleModelName = "Tata Starbus"
                        },
                        new
                        {
                            ModelId = 7,
                            VehicleModelName = "Eicher Skyline"
                        },
                        new
                        {
                            ModelId = 8,
                            VehicleModelName = "Ashok Leyland Viking"
                        },
                        new
                        {
                            ModelId = 9,
                            VehicleModelName = "Force Traveller"
                        },
                        new
                        {
                            ModelId = 10,
                            VehicleModelName = "Mahindra Supro"
                        },
                        new
                        {
                            ModelId = 11,
                            VehicleModelName = "Mahindra Thar"
                        },
                        new
                        {
                            ModelId = 12,
                            VehicleModelName = "Suzuki Jimny"
                        },
                        new
                        {
                            ModelId = 13,
                            VehicleModelName = "Jeep Compass"
                        },
                        new
                        {
                            ModelId = 14,
                            VehicleModelName = "Toyota Land Cruiser"
                        },
                        new
                        {
                            ModelId = 15,
                            VehicleModelName = "Ford Everest"
                        },
                        new
                        {
                            ModelId = 16,
                            VehicleModelName = "Tata LPT 1613"
                        },
                        new
                        {
                            ModelId = 17,
                            VehicleModelName = "Ashok Leyland Dost"
                        },
                        new
                        {
                            ModelId = 18,
                            VehicleModelName = "Eicher Pro 3016"
                        },
                        new
                        {
                            ModelId = 19,
                            VehicleModelName = "Mahindra Blazo"
                        },
                        new
                        {
                            ModelId = 20,
                            VehicleModelName = "Isuzu NPR"
                        },
                        new
                        {
                            ModelId = 21,
                            VehicleModelName = "Honda Shine"
                        },
                        new
                        {
                            ModelId = 22,
                            VehicleModelName = "Bajaj Pulsar 150"
                        },
                        new
                        {
                            ModelId = 23,
                            VehicleModelName = "Yamaha FZ"
                        },
                        new
                        {
                            ModelId = 24,
                            VehicleModelName = "KTM Duke 200"
                        },
                        new
                        {
                            ModelId = 25,
                            VehicleModelName = "Royal Enfield Classic 350"
                        },
                        new
                        {
                            ModelId = 26,
                            VehicleModelName = "Honda Dio"
                        },
                        new
                        {
                            ModelId = 27,
                            VehicleModelName = "TVS Jupiter"
                        },
                        new
                        {
                            ModelId = 28,
                            VehicleModelName = "Suzuki Access 125"
                        },
                        new
                        {
                            ModelId = 29,
                            VehicleModelName = "Vespa SXL 150"
                        },
                        new
                        {
                            ModelId = 30,
                            VehicleModelName = "Yamaha Fascino"
                        },
                        new
                        {
                            ModelId = 31,
                            VehicleModelName = "Suzuki Eeco"
                        },
                        new
                        {
                            ModelId = 32,
                            VehicleModelName = "Tata Winger"
                        },
                        new
                        {
                            ModelId = 33,
                            VehicleModelName = "Mahindra Supro Van"
                        },
                        new
                        {
                            ModelId = 34,
                            VehicleModelName = "Hyundai H1"
                        },
                        new
                        {
                            ModelId = 35,
                            VehicleModelName = "Nissan NV350"
                        },
                        new
                        {
                            ModelId = 36,
                            VehicleModelName = "Mahindra Bolero Camper"
                        },
                        new
                        {
                            ModelId = 37,
                            VehicleModelName = "Isuzu D-Max"
                        },
                        new
                        {
                            ModelId = 38,
                            VehicleModelName = "Tata Xenon"
                        },
                        new
                        {
                            ModelId = 39,
                            VehicleModelName = "Ford Ranger"
                        },
                        new
                        {
                            ModelId = 40,
                            VehicleModelName = "Toyota Hilux"
                        },
                        new
                        {
                            ModelId = 41,
                            VehicleModelName = "Mahindra Yuvo"
                        },
                        new
                        {
                            ModelId = 42,
                            VehicleModelName = "Sonalika DI 745"
                        },
                        new
                        {
                            ModelId = 43,
                            VehicleModelName = "Swaraj 744 FE"
                        },
                        new
                        {
                            ModelId = 44,
                            VehicleModelName = "John Deere 5050D"
                        },
                        new
                        {
                            ModelId = 45,
                            VehicleModelName = "Massey Ferguson 241"
                        },
                        new
                        {
                            ModelId = 46,
                            VehicleModelName = "Toyota HiAce"
                        },
                        new
                        {
                            ModelId = 47,
                            VehicleModelName = "Nissan Urvan"
                        },
                        new
                        {
                            ModelId = 48,
                            VehicleModelName = "Mahindra Supro Maxitruck"
                        },
                        new
                        {
                            ModelId = 49,
                            VehicleModelName = "Hyundai Starex"
                        },
                        new
                        {
                            ModelId = 50,
                            VehicleModelName = "Bajaj RE"
                        },
                        new
                        {
                            ModelId = 51,
                            VehicleModelName = "Piaggio Ape"
                        },
                        new
                        {
                            ModelId = 52,
                            VehicleModelName = "Mahindra Alfa"
                        },
                        new
                        {
                            ModelId = 53,
                            VehicleModelName = "Atul Shakti"
                        },
                        new
                        {
                            ModelId = 54,
                            VehicleModelName = "TVS King"
                        },
                        new
                        {
                            ModelId = 55,
                            VehicleModelName = "Lohia Comfort"
                        },
                        new
                        {
                            ModelId = 56,
                            VehicleModelName = "Bajaj RE E-Rickshaw"
                        },
                        new
                        {
                            ModelId = 57,
                            VehicleModelName = "Kinetic Safar"
                        },
                        new
                        {
                            ModelId = 58,
                            VehicleModelName = "Mahindra Treo"
                        },
                        new
                        {
                            ModelId = 59,
                            VehicleModelName = "Mayuri E-Rickshaw"
                        },
                        new
                        {
                            ModelId = 60,
                            VehicleModelName = "Hero Sprint"
                        },
                        new
                        {
                            ModelId = 61,
                            VehicleModelName = "Atlas Goldline"
                        },
                        new
                        {
                            ModelId = 62,
                            VehicleModelName = "Firefox Target"
                        },
                        new
                        {
                            ModelId = 63,
                            VehicleModelName = "Giant Talon"
                        },
                        new
                        {
                            ModelId = 64,
                            VehicleModelName = "Trek Marlin"
                        },
                        new
                        {
                            ModelId = 65,
                            VehicleModelName = "Mahindra Scorpio"
                        },
                        new
                        {
                            ModelId = 66,
                            VehicleModelName = "Ford Endeavour"
                        },
                        new
                        {
                            ModelId = 67,
                            VehicleModelName = "Toyota Fortuner"
                        },
                        new
                        {
                            ModelId = 68,
                            VehicleModelName = "Hyundai Creta"
                        },
                        new
                        {
                            ModelId = 69,
                            VehicleModelName = "Nissan Patrol"
                        },
                        new
                        {
                            ModelId = 70,
                            VehicleModelName = "Suzuki Omni"
                        },
                        new
                        {
                            ModelId = 71,
                            VehicleModelName = "Maruti Eeco"
                        },
                        new
                        {
                            ModelId = 72,
                            VehicleModelName = "Hyundai Staria"
                        },
                        new
                        {
                            ModelId = 73,
                            VehicleModelName = "Tata Venture"
                        },
                        new
                        {
                            ModelId = 74,
                            VehicleModelName = "Nissan NV200"
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
                    b.Navigation("BookingConfirmation")
                        .IsRequired();
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
