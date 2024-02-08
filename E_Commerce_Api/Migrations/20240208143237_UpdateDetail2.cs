using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce_Api.Migrations
{
    public partial class UpdateDetail2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AltKategoriIdenty",
                table: "Urun");

            migrationBuilder.DropColumn(
                name: "UrunIdenty",
                table: "Sepet");

            migrationBuilder.DropColumn(
                name: "UserIdenty",
                table: "Sepet");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AltKategoriIdenty",
                table: "Urun",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UrunIdenty",
                table: "Sepet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserIdenty",
                table: "Sepet",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
