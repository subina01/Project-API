using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Carrental.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 15);

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

            migrationBuilder.UpdateData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 1,
                columns: new[] { "RentalCharge", "VehicleBrandName" },
                values: new object[] { 6000m, "Hyundai" });

            migrationBuilder.UpdateData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 2,
                columns: new[] { "RentalCharge", "VehicleBrandName" },
                values: new object[] { 5100m, "Suzuki" });

            migrationBuilder.UpdateData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 3,
                columns: new[] { "RentalCharge", "VehicleBrandName" },
                values: new object[] { 7500m, "Toyota" });

            migrationBuilder.UpdateData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 5,
                columns: new[] { "RentalCharge", "VehicleBrandName" },
                values: new object[] { 5500m, "Tata Motors" });

            migrationBuilder.UpdateData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 6,
                columns: new[] { "RentalCharge", "VehicleBrandName" },
                values: new object[] { 4000m, "Ashok Leyland" });

            migrationBuilder.UpdateData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 7,
                columns: new[] { "RentalCharge", "VehicleBrandName" },
                values: new object[] { 4800m, "Mahindra" });

            migrationBuilder.UpdateData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 8,
                columns: new[] { "RentalCharge", "VehicleBrandName" },
                values: new object[] { 5000m, "Eicher" });

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "VehicleCategoryName",
                value: "Sumo");

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "VehicleCategoryName",
                value: "Minivan");

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "VehicleCategoryName",
                value: "Jeep");

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "VehicleCategoryName",
                value: "Microbus");

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "VehicleCategoryName",
                value: "Tempo");

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "VehicleCategoryName",
                value: "Van");

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "VehicleCategoryName",
                value: "Scooter");

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "VehicleCategoryName",
                value: "Cycle");

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 12,
                column: "VehicleCategoryName",
                value: "Bike");

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 13,
                column: "VehicleCategoryName",
                value: "Scorpio");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 1,
                column: "VehicleModelName",
                value: "i10");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 2,
                column: "VehicleModelName",
                value: "i20");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 3,
                column: "VehicleModelName",
                value: "Creta");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 4,
                column: "VehicleModelName",
                value: "Santro");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 5,
                column: "VehicleModelName",
                value: "Alto");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 6,
                column: "VehicleModelName",
                value: "Swift");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 7,
                column: "VehicleModelName",
                value: "WagonR");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 8,
                column: "VehicleModelName",
                value: "Celerio");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 9,
                column: "VehicleModelName",
                value: "Corolla");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 10,
                column: "VehicleModelName",
                value: "Yaris");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 11,
                column: "VehicleModelName",
                value: "Vitz");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 12,
                column: "VehicleModelName",
                value: "City");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 13,
                column: "VehicleModelName",
                value: "Amaze");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 14,
                column: "VehicleModelName",
                value: "Jazz");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 15,
                column: "VehicleModelName",
                value: "Tiago");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 16,
                column: "VehicleModelName",
                value: "Nexon");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 17,
                column: "VehicleModelName",
                value: "Tigor");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 18,
                column: "VehicleModelName",
                value: "LP 407");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 19,
                column: "VehicleModelName",
                value: "LP 1512");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 20,
                column: "VehicleModelName",
                value: "Viking");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 21,
                column: "VehicleModelName",
                value: "Cheetah");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 22,
                column: "VehicleModelName",
                value: "Cruzio");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 23,
                column: "VehicleModelName",
                value: "Supro Bus");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 24,
                column: "VehicleModelName",
                value: "Skyline");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 25,
                column: "VehicleModelName",
                value: "Starline");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 26,
                column: "VehicleModelName",
                value: "Sumo Gold");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 27,
                column: "VehicleModelName",
                value: "Sumo Victa");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 28,
                column: "VehicleModelName",
                value: "Bolero");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 29,
                column: "VehicleModelName",
                value: "Scorpio");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 30,
                column: "VehicleModelName",
                value: "Blazo");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 31,
                column: "VehicleModelName",
                value: "Furio");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 32,
                column: "VehicleModelName",
                value: "Pro 3015");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 33,
                column: "VehicleModelName",
                value: "Pro 2049");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 34,
                column: "VehicleModelName",
                value: "Dost+");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 35,
                column: "VehicleModelName",
                value: "2516 IL");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 36,
                column: "VehicleModelName",
                value: "Eeco");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 37,
                column: "VehicleModelName",
                value: "Omni");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 38,
                column: "VehicleModelName",
                value: "Venture");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 39,
                column: "VehicleModelName",
                value: "Winger");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 40,
                column: "VehicleModelName",
                value: "Supro Van");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 41,
                column: "VehicleModelName",
                value: "Bolero Camper");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 1,
                columns: new[] { "RentalCharge", "VehicleBrandName" },
                values: new object[] { 5000m, "Maruti Suzuki" });

            migrationBuilder.UpdateData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 2,
                columns: new[] { "RentalCharge", "VehicleBrandName" },
                values: new object[] { 6000m, "Hyundai" });

            migrationBuilder.UpdateData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 3,
                columns: new[] { "RentalCharge", "VehicleBrandName" },
                values: new object[] { 5500m, "Tata Motors" });

            migrationBuilder.UpdateData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 5,
                columns: new[] { "RentalCharge", "VehicleBrandName" },
                values: new object[] { 7500m, "Toyota" });

            migrationBuilder.UpdateData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 6,
                columns: new[] { "RentalCharge", "VehicleBrandName" },
                values: new object[] { 6500m, "Ford" });

            migrationBuilder.UpdateData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 7,
                columns: new[] { "RentalCharge", "VehicleBrandName" },
                values: new object[] { 6200m, "Nissan" });

            migrationBuilder.UpdateData(
                table: "VehicleBrands",
                keyColumn: "BrandId",
                keyValue: 8,
                columns: new[] { "RentalCharge", "VehicleBrandName" },
                values: new object[] { 4800m, "Mahindra" });

            migrationBuilder.InsertData(
                table: "VehicleBrands",
                columns: new[] { "BrandId", "RentalCharge", "VehicleBrandName" },
                values: new object[,]
                {
                    { 9, 5100m, "Suzuki" },
                    { 10, 8000m, "Isuzu" },
                    { 11, 3000m, "KTM" },
                    { 12, 2800m, "Bajaj" },
                    { 13, 2900m, "Yamaha" },
                    { 14, 3500m, "Royal Enfield" },
                    { 15, 4000m, "Ashok Leyland" }
                });

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "VehicleCategoryName",
                value: "Jeep");

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "VehicleCategoryName",
                value: "Motorbike");

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "VehicleCategoryName",
                value: "Scooter");

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "VehicleCategoryName",
                value: "Minivan");

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "VehicleCategoryName",
                value: "Pickup");

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "VehicleCategoryName",
                value: "Tractor");

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "VehicleCategoryName",
                value: "Microbus");

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 11,
                column: "VehicleCategoryName",
                value: "Tempo");

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 12,
                column: "VehicleCategoryName",
                value: "Electric Rickshaw");

            migrationBuilder.UpdateData(
                table: "VehicleCategories",
                keyColumn: "CategoryId",
                keyValue: 13,
                column: "VehicleCategoryName",
                value: "Bicycle");

            migrationBuilder.InsertData(
                table: "VehicleCategories",
                columns: new[] { "CategoryId", "VehicleCategoryName" },
                values: new object[,]
                {
                    { 14, "SUV" },
                    { 15, "Van" }
                });

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 1,
                column: "VehicleModelName",
                value: "Maruti Suzuki Alto");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 2,
                column: "VehicleModelName",
                value: "Hyundai i20");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 3,
                column: "VehicleModelName",
                value: "Tata Nexon");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 4,
                column: "VehicleModelName",
                value: "Honda City");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 5,
                column: "VehicleModelName",
                value: "Toyota Corolla");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 6,
                column: "VehicleModelName",
                value: "Tata Starbus");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 7,
                column: "VehicleModelName",
                value: "Eicher Skyline");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 8,
                column: "VehicleModelName",
                value: "Ashok Leyland Viking");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 9,
                column: "VehicleModelName",
                value: "Force Traveller");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 10,
                column: "VehicleModelName",
                value: "Mahindra Supro");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 11,
                column: "VehicleModelName",
                value: "Mahindra Thar");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 12,
                column: "VehicleModelName",
                value: "Suzuki Jimny");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 13,
                column: "VehicleModelName",
                value: "Jeep Compass");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 14,
                column: "VehicleModelName",
                value: "Toyota Land Cruiser");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 15,
                column: "VehicleModelName",
                value: "Ford Everest");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 16,
                column: "VehicleModelName",
                value: "Tata LPT 1613");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 17,
                column: "VehicleModelName",
                value: "Ashok Leyland Dost");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 18,
                column: "VehicleModelName",
                value: "Eicher Pro 3016");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 19,
                column: "VehicleModelName",
                value: "Mahindra Blazo");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 20,
                column: "VehicleModelName",
                value: "Isuzu NPR");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 21,
                column: "VehicleModelName",
                value: "Honda Shine");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 22,
                column: "VehicleModelName",
                value: "Bajaj Pulsar 150");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 23,
                column: "VehicleModelName",
                value: "Yamaha FZ");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 24,
                column: "VehicleModelName",
                value: "KTM Duke 200");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 25,
                column: "VehicleModelName",
                value: "Royal Enfield Classic 350");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 26,
                column: "VehicleModelName",
                value: "Honda Dio");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 27,
                column: "VehicleModelName",
                value: "TVS Jupiter");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 28,
                column: "VehicleModelName",
                value: "Suzuki Access 125");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 29,
                column: "VehicleModelName",
                value: "Vespa SXL 150");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 30,
                column: "VehicleModelName",
                value: "Yamaha Fascino");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 31,
                column: "VehicleModelName",
                value: "Suzuki Eeco");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 32,
                column: "VehicleModelName",
                value: "Tata Winger");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 33,
                column: "VehicleModelName",
                value: "Mahindra Supro Van");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 34,
                column: "VehicleModelName",
                value: "Hyundai H1");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 35,
                column: "VehicleModelName",
                value: "Nissan NV350");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 36,
                column: "VehicleModelName",
                value: "Mahindra Bolero Camper");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 37,
                column: "VehicleModelName",
                value: "Isuzu D-Max");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 38,
                column: "VehicleModelName",
                value: "Tata Xenon");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 39,
                column: "VehicleModelName",
                value: "Ford Ranger");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 40,
                column: "VehicleModelName",
                value: "Toyota Hilux");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "ModelId",
                keyValue: 41,
                column: "VehicleModelName",
                value: "Mahindra Yuvo");

            migrationBuilder.InsertData(
                table: "VehicleModels",
                columns: new[] { "ModelId", "VehicleModelName" },
                values: new object[,]
                {
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
    }
}
