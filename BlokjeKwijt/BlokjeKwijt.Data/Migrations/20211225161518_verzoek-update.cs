using Microsoft.EntityFrameworkCore.Migrations;

namespace BlokjeKwijt.Data.Migrations
{
    public partial class verzoekupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "BlokjesVerzoeken",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Naam",
                table: "BlokjesVerzoeken",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelefoonNummer",
                table: "BlokjesVerzoeken",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "BlokjesVerzoeken");

            migrationBuilder.DropColumn(
                name: "Naam",
                table: "BlokjesVerzoeken");

            migrationBuilder.DropColumn(
                name: "TelefoonNummer",
                table: "BlokjesVerzoeken");
        }
    }
}
