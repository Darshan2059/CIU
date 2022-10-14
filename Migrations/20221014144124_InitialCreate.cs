using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CIU.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Soap",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    LotteryTicket = table.Column<string>(nullable: true),
                    Membership_Discount = table.Column<string>(nullable: true),
                    Normal_Price = table.Column<decimal>(nullable: false),
                    Members_Price = table.Column<decimal>(nullable: false),
                    Rating = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soap", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Soap");
        }
    }
}
