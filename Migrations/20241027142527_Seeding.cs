using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Carrental.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "RentalCharge",
                table: "VehicleBrands",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "VehicleBrands",
                columns: new[] { "BrandId", "RentalCharge", "VehicleBrandName" },
                values: new object[,]
                {
                    { 1, 5000m, "Maruti Suzuki" },
                    { 2, 6000m, "Hyundai" },
                    { 3, 5500m, "Tata Motors" },
                    { 4, 7000m, "Honda" },
                    { 5, 7500m, "Toyota" },
                    { 6, 6500m, "Ford" },
                    { 7, 6200m, "Nissan" },
                    { 8, 4800m, "Mahindra" },
                    { 9, 5100m, "Suzuki" },
                    { 10, 8000m, "Isuzu" },
                    { 11, 3000m, "KTM" },
                    { 12, 2800m, "Bajaj" },
                    { 13, 2900m, "Yamaha" },
                    { 14, 3500m, "Royal Enfield" },
                    { 15, 4000m, "Ashok Leyland" }
                });

            migrationBuilder.InsertData(
                table: "VehicleCategories",
                columns: new[] { "CategoryId", "VehicleCategoryName" },
                values: new object[,]
                {
                    { 1, "Car" },
                    { 2, "Bus" },
                    { 3, "Jeep" },
                    { 4, "Truck" },
                    { 5, "Motorbike" },
                    { 6, "Scooter" },
                    { 7, "Minivan" },
                    { 8, "Pickup" },
                    { 9, "Tractor" },
                    { 10, "Microbus" },
                    { 11, "Tempo" },
                    { 12, "Electric Rickshaw" },
                    { 13, "Bicycle" },
                    { 14, "SUV" },
                    { 15, "Van" }
                });

            migrationBuilder.InsertData(
                table: "VehicleModels",
                columns: new[] { "ModelId", "VehicleModelName" },
                values: new object[,]
                {
                    { 1, "Maruti Suzuki Alto" },
                    { 2, "Hyundai i20" },
                    { 3, "Tata Nexon" },
                    { 4, "Honda City" },
                    { 5, "Toyota Corolla" },
                    { 6, "Tata Starbus" },
                    { 7, "Eicher Skyline" },
                    { 8, "Ashok Leyland Viking" },
                    { 9, "Force Traveller" },
                    { 10, "Mahindra Supro" },
                    { 11, "Mahindra Thar" },
                    { 12, "Suzuki Jimny" },
                    { 13, "Jeep Compass" },
                    { 14, "Toyota Land Cruiser" },
                    { 15, "Ford Everest" },
                    { 16, "Tata LPT 1613" },
                    { 17, "Ashok Leyland Dost" },
                    { 18, "Eicher Pro 3016" },
                    { 19, "Mahindra Blazo" },
                    { 20, "Isuzu NPR" },
                    { 21, "Honda Shine" },
                    { 22, "Bajaj Pulsar 150" },
                    { 23, "Yamaha FZ" },
                    { 24, "KTM Duke 200" },
                    { 25, "Royal Enfield Classic 350" },
                    { 26, "Honda Dio" },
                    { 27, "TVS Jupiter" },
                    { 28, "Suzuki Access 125" },
                    { 29, "Vespa SXL 150" },
                    { 30, "Yamaha Fascino" },
                    { 31, "Suzuki Eeco" },
                    { 32, "Tata Winger" },
                    { 33, "Mahindra Supro Van" },
                    { 34, "Hyundai H1" },
                    { 35, "Nissan NV350" },
                    { 36, "Mahindra Bolero Camper" },
                    { 37, "Isuzu D-Max" },
                    { 38, "Tata Xenon" },
                    { 39, "Ford Ranger" },
                    { 40, "Toyota Hilux" },
                    { 41, "Mahindra Yuvo" },
                    { 42, "Sonalika DI 745" },
                    { 43, "Swaraj 744 FE" },
                    { 44, "John Deere 5050D" },
                    { 45, "Massey Ferguson 241" },
                    { 46, "Toyota HiAce" },
                    { 47, "Nissan Urvan" },
                    { 48, "Mahindra Supro Maxitruck" },
                    { 49, "Hyundai Starex" },
                    { 50, "Bajaj RE" },
                    { 51, "Piaggio Ape" },
                    { 52, "Mahindra Alfa" },
                    { 53, "Atul Shakti" },
                    { 54, "TVS King" },
                    { 55, "Lohia Comfort" },
                    { 56, "Bajaj RE E-Rickshaw" },
                    { 57, "Kinetic Safar" },
                    { 58, "Mahindra Treo" },
                    { 59, "Mayuri E-Rickshaw" },
                    { 60, "Hero Sprint" },
                    { 61, "Atlas Goldline" },
                    { 62, "Firefox Target" },
                    { 63, "Giant Talon" },
                    { 64, "Trek Marlin" },
                    { 65, "Mahindra Scorpio" },
                    { 66, "Ford Endeavour" },
                    { 67, "Toyota Fortuner" },
                    { 68, "Hyundai Creta" },
                    { 69, "Nissan Patrol" },
                    { 70, "Suzuki Omni" },
                    { 71, "Maruti Eeco" },
                    { 72, "Hyundai Staria" },
                    { 73, "Tata Venture" },
                    { 74, "Nissan NV200" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 74);

            migrationBuilder.DropColumn(
                name: "RentalCharge",
                table: "VehicleBrands");
        }
    }
}
