using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Automobili",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    model = table.Column<string>(type: "TEXT", nullable: true),
                    cena = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automobili", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Karoserije",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Vrsta = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karoserije", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KonjskeSnage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Vrsta = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KonjskeSnage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kubikaze",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Vrsta = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kubikaze", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Opreme",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Vrsta = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opreme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pogoni",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Vrsta = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pogoni", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Automobili");

            migrationBuilder.DropTable(
                name: "Karoserije");

            migrationBuilder.DropTable(
                name: "KonjskeSnage");

            migrationBuilder.DropTable(
                name: "Kubikaze");

            migrationBuilder.DropTable(
                name: "Opreme");

            migrationBuilder.DropTable(
                name: "Pogoni");
        }
    }
}
