using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carrental.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedFunctionality : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "CNICimg",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "SecretCode",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "VerifyCode",
                table: "Bookings",
                newName: "CNICimgPath");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "CNICimgPath",
                table: "Bookings",
                newName: "VerifyCode");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Vehicles",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CNICimg",
                table: "Bookings",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecretCode",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
