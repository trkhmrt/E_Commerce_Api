using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce_Api.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    Kategoriid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.Kategoriid);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Userid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Userid);
                });

            migrationBuilder.CreateTable(
                name: "AltKategori",
                columns: table => new
                {
                    AltKategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AltKategoriName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kategoriid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AltKategori", x => x.AltKategoriID);
                    table.ForeignKey(
                        name: "FK_AltKategori_Kategori_Kategoriid",
                        column: x => x.Kategoriid,
                        principalTable: "Kategori",
                        principalColumn: "Kategoriid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Urun",
                columns: table => new
                {
                    Urunid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrunAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AltKategoriIdenty = table.Column<int>(type: "int", nullable: false),
                    AltKategoriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urun", x => x.Urunid);
                    table.ForeignKey(
                        name: "FK_Urun_AltKategori_AltKategoriID",
                        column: x => x.AltKategoriID,
                        principalTable: "AltKategori",
                        principalColumn: "AltKategoriID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sepet",
                columns: table => new
                {
                    Sepetid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserIdenty = table.Column<int>(type: "int", nullable: false),
                    Userid = table.Column<int>(type: "int", nullable: false),
                    UrunIdenty = table.Column<int>(type: "int", nullable: false),
                    Urunid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sepet", x => x.Sepetid);
                    table.ForeignKey(
                        name: "FK_Sepet_Urun_Urunid",
                        column: x => x.Urunid,
                        principalTable: "Urun",
                        principalColumn: "Urunid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sepet_Users_Userid",
                        column: x => x.Userid,
                        principalTable: "Users",
                        principalColumn: "Userid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AltKategori_Kategoriid",
                table: "AltKategori",
                column: "Kategoriid");

            migrationBuilder.CreateIndex(
                name: "IX_Sepet_Urunid",
                table: "Sepet",
                column: "Urunid");

            migrationBuilder.CreateIndex(
                name: "IX_Sepet_Userid",
                table: "Sepet",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_Urun_AltKategoriID",
                table: "Urun",
                column: "AltKategoriID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sepet");

            migrationBuilder.DropTable(
                name: "Urun");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "AltKategori");

            migrationBuilder.DropTable(
                name: "Kategori");
        }
    }
}
