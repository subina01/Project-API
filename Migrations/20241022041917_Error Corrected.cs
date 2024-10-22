using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carrental.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class ErrorCorrected : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePaths",
                table: "Vehicles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePaths",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
