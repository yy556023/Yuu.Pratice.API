using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yuu.Pratice.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTouristRouteSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "DepartureCity",
                table: "TouristRoute",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "TouristRoute",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "TravelDays",
                table: "TouristRoute",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "TripType",
                table: "TouristRoute",
                type: "tinyint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartureCity",
                table: "TouristRoute");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "TouristRoute");

            migrationBuilder.DropColumn(
                name: "TravelDays",
                table: "TouristRoute");

            migrationBuilder.DropColumn(
                name: "TripType",
                table: "TouristRoute");
        }
    }
}
