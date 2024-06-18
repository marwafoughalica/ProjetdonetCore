using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mini_ProjetDonetCore.Migrations
{
    /// <inheritdoc />
    public partial class finalllllllllllllllll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "client",
                columns: table => new
                {
                    IdCl = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telephone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client", x => x.IdCl);
                });

            migrationBuilder.CreateTable(
                name: "location",
                columns: table => new
                {
                    IdLoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdVoi = table.Column<int>(type: "int", nullable: false),
                    IdCl = table.Column<int>(type: "int", nullable: false),
                    dateLoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateRetour = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_location", x => x.IdLoc);
                });

            migrationBuilder.CreateTable(
                name: "voiture",
                columns: table => new
                {
                    IdVoi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    matricule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date_sortie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    couleur = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_voiture", x => x.IdVoi);
                });

            migrationBuilder.CreateTable(
                name: "ClientLocation",
                columns: table => new
                {
                    IdCl = table.Column<int>(type: "int", nullable: false),
                    clientIdCl = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientLocation", x => new { x.IdCl, x.clientIdCl });
                    table.ForeignKey(
                        name: "FK_ClientLocation_client_clientIdCl",
                        column: x => x.clientIdCl,
                        principalTable: "client",
                        principalColumn: "IdCl",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientLocation_location_IdCl",
                        column: x => x.IdCl,
                        principalTable: "location",
                        principalColumn: "IdLoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationVoiture",
                columns: table => new
                {
                    IdVoi = table.Column<int>(type: "int", nullable: false),
                    VoitureIdVoi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationVoiture", x => new { x.IdVoi, x.VoitureIdVoi });
                    table.ForeignKey(
                        name: "FK_LocationVoiture_location_IdVoi",
                        column: x => x.IdVoi,
                        principalTable: "location",
                        principalColumn: "IdLoc",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationVoiture_voiture_VoitureIdVoi",
                        column: x => x.VoitureIdVoi,
                        principalTable: "voiture",
                        principalColumn: "IdVoi",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientLocation_clientIdCl",
                table: "ClientLocation",
                column: "clientIdCl");

            migrationBuilder.CreateIndex(
                name: "IX_LocationVoiture_VoitureIdVoi",
                table: "LocationVoiture",
                column: "VoitureIdVoi");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientLocation");

            migrationBuilder.DropTable(
                name: "LocationVoiture");

            migrationBuilder.DropTable(
                name: "client");

            migrationBuilder.DropTable(
                name: "location");

            migrationBuilder.DropTable(
                name: "voiture");
        }
    }
}
