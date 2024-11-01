using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carrental.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Bookingsucessful : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BookingConfirmations_BookingId",
                table: "BookingConfirmations");

            migrationBuilder.CreateIndex(
                name: "IX_BookingConfirmations_BookingId",
                table: "BookingConfirmations",
                column: "BookingId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BookingConfirmations_BookingId",
                table: "BookingConfirmations");

            migrationBuilder.CreateIndex(
                name: "IX_BookingConfirmations_BookingId",
                table: "BookingConfirmations",
                column: "BookingId");
        }
    }
}
