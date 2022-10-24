using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking.Web.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingID = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    BookingTime = table.Column<DateTime>(nullable: false),
                    MovieName = table.Column<string>(nullable: true),
                    ImageFile = table.Column<string>(nullable: true),
                    Datetime = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHistory", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderHistory");
        }
    }
}
