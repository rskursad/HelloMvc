using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sube2.HelloMvc.Migrations
{
    /// <inheritdoc />
    public partial class OgrenciClassUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Soyad",
                table: "tblOgrenciler",
                newName: "soyad");

            migrationBuilder.RenameColumn(
                name: "Ad",
                table: "tblOgrenciler",
                newName: "ad");

            migrationBuilder.RenameColumn(
                name: "Ogrenciid",
                table: "tblOgrenciler",
                newName: "ogrenciId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "soyad",
                table: "tblOgrenciler",
                newName: "Soyad");

            migrationBuilder.RenameColumn(
                name: "ad",
                table: "tblOgrenciler",
                newName: "Ad");

            migrationBuilder.RenameColumn(
                name: "ogrenciId",
                table: "tblOgrenciler",
                newName: "Ogrenciid");
        }
    }
}
