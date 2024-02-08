using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce_Api.Migrations
{
    public partial class UpdateDetail33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sepet_Urun_Urunid",
                table: "Sepet");

            migrationBuilder.DropForeignKey(
                name: "FK_Urun_AltKategori_AltKategoriID",
                table: "Urun");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Urun",
                table: "Urun");

            migrationBuilder.RenameTable(
                name: "Urun",
                newName: "Uruns");

            migrationBuilder.RenameIndex(
                name: "IX_Urun_AltKategoriID",
                table: "Uruns",
                newName: "IX_Uruns_AltKategoriID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Uruns",
                table: "Uruns",
                column: "Urunid");

            migrationBuilder.AddForeignKey(
                name: "FK_Sepet_Uruns_Urunid",
                table: "Sepet",
                column: "Urunid",
                principalTable: "Uruns",
                principalColumn: "Urunid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Uruns_AltKategori_AltKategoriID",
                table: "Uruns",
                column: "AltKategoriID",
                principalTable: "AltKategori",
                principalColumn: "AltKategoriID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sepet_Uruns_Urunid",
                table: "Sepet");

            migrationBuilder.DropForeignKey(
                name: "FK_Uruns_AltKategori_AltKategoriID",
                table: "Uruns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Uruns",
                table: "Uruns");

            migrationBuilder.RenameTable(
                name: "Uruns",
                newName: "Urun");

            migrationBuilder.RenameIndex(
                name: "IX_Uruns_AltKategoriID",
                table: "Urun",
                newName: "IX_Urun_AltKategoriID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Urun",
                table: "Urun",
                column: "Urunid");

            migrationBuilder.AddForeignKey(
                name: "FK_Sepet_Urun_Urunid",
                table: "Sepet",
                column: "Urunid",
                principalTable: "Urun",
                principalColumn: "Urunid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Urun_AltKategori_AltKategoriID",
                table: "Urun",
                column: "AltKategoriID",
                principalTable: "AltKategori",
                principalColumn: "AltKategoriID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
