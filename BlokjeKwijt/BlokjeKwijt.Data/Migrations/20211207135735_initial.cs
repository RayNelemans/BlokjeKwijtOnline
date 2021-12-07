using Microsoft.EntityFrameworkCore.Migrations;

namespace BlokjeKwijt.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aanvragen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefoonNummer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bericht = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aanvragen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlokjesVerzoeken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlokjeId = table.Column<int>(type: "int", nullable: false),
                    BlokjeOverKwijt = table.Column<int>(type: "int", nullable: false),
                    BlokjesVerzoekStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlokjesVerzoeken", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gebruikers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefoonNummer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gebruikers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kleuren",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KleurNaam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KleurCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kleuren", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blokjes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlokNummer = table.Column<int>(type: "int", nullable: false),
                    Lengte = table.Column<int>(type: "int", nullable: false),
                    Breedte = table.Column<int>(type: "int", nullable: false),
                    Hoogte = table.Column<int>(type: "int", nullable: false),
                    Nopjes = table.Column<int>(type: "int", nullable: false),
                    KleurId = table.Column<int>(type: "int", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blokjes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blokjes_Kleuren_KleurId",
                        column: x => x.KleurId,
                        principalTable: "Kleuren",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Aanvragen",
                columns: new[] { "Id", "Bericht", "Email", "Naam", "TelefoonNummer" },
                values: new object[,]
                {
                    { 1, "Ik zou graag een groen blokje aan willen vragen met 6 nopjes", "ray@home.nl", "Ray", "0612345678" },
                    { 2, "Ik zou graag een roze blokje willen aanvragen met 12 nopjes", "gijs@home.nl", "Gijs", "0615935712" },
                    { 3, "Ik zou graag een oranje blokje aan willen vragen met 14 nopjes", "nick@home.nl", "Nick", "0687654321" }
                });

            migrationBuilder.InsertData(
                table: "BlokjesVerzoeken",
                columns: new[] { "Id", "BlokjeId", "BlokjeOverKwijt", "BlokjesVerzoekStatus" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 1, 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Gebruikers",
                columns: new[] { "Id", "Email", "Naam", "TelefoonNummer" },
                values: new object[,]
                {
                    { 1, "ray@home.nl", "Ray", "0612345678" },
                    { 2, "gijs@home.nl", "Gijs", "0615935712" },
                    { 3, "nick@home.nl", "Nick", "0687654321" }
                });

            migrationBuilder.InsertData(
                table: "Kleuren",
                columns: new[] { "Id", "KleurCode", "KleurNaam" },
                values: new object[,]
                {
                    { 1, "#ff0000", "Rood" },
                    { 2, "##FFFF00", "Geel" },
                    { 3, "#0000FF", "Blauw" }
                });

            migrationBuilder.InsertData(
                table: "Blokjes",
                columns: new[] { "Id", "BlokNummer", "Breedte", "Hoogte", "ImageName", "KleurId", "Lengte", "Nopjes" },
                values: new object[] { 1, 10, 5, 1, "Rood.jpg", 1, 10, 50 });

            migrationBuilder.InsertData(
                table: "Blokjes",
                columns: new[] { "Id", "BlokNummer", "Breedte", "Hoogte", "ImageName", "KleurId", "Lengte", "Nopjes" },
                values: new object[] { 2, 5, 2, 2, "Geel.jpg", 2, 4, 20 });

            migrationBuilder.InsertData(
                table: "Blokjes",
                columns: new[] { "Id", "BlokNummer", "Breedte", "Hoogte", "ImageName", "KleurId", "Lengte", "Nopjes" },
                values: new object[] { 3, 8, 5, 0, "Blauw.jpg", 3, 4, 32 });

            migrationBuilder.CreateIndex(
                name: "IX_Blokjes_KleurId",
                table: "Blokjes",
                column: "KleurId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aanvragen");

            migrationBuilder.DropTable(
                name: "Blokjes");

            migrationBuilder.DropTable(
                name: "BlokjesVerzoeken");

            migrationBuilder.DropTable(
                name: "Gebruikers");

            migrationBuilder.DropTable(
                name: "Kleuren");
        }
    }
}
