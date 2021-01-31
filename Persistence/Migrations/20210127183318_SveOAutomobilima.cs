using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SveOAutomobilima : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SveOAutomobilima",
                columns: table => new
                {
                    KaroserijaId = table.Column<Guid>(type: "TEXT", nullable: false),
                    KubikazaId = table.Column<Guid>(type: "TEXT", nullable: false),
                    KwksId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PogonId = table.Column<Guid>(type: "TEXT", nullable: false),
                    OpremaId = table.Column<Guid>(type: "TEXT", nullable: false),
                    AutomobilId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SveOAutomobilima", x => new { x.KaroserijaId, x.KubikazaId, x.KwksId, x.PogonId, x.OpremaId });
                    table.ForeignKey(
                        name: "FK_SveOAutomobilima_Automobili_AutomobilId",
                        column: x => x.AutomobilId,
                        principalTable: "Automobili",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SveOAutomobilima_Karoserije_KaroserijaId",
                        column: x => x.KaroserijaId,
                        principalTable: "Karoserije",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SveOAutomobilima_KonjskeSnage_KwksId",
                        column: x => x.KwksId,
                        principalTable: "KonjskeSnage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SveOAutomobilima_Kubikaze_KubikazaId",
                        column: x => x.KubikazaId,
                        principalTable: "Kubikaze",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SveOAutomobilima_Opreme_OpremaId",
                        column: x => x.OpremaId,
                        principalTable: "Opreme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SveOAutomobilima_Pogoni_PogonId",
                        column: x => x.PogonId,
                        principalTable: "Pogoni",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SveOAutomobilima_AutomobilId",
                table: "SveOAutomobilima",
                column: "AutomobilId");

            migrationBuilder.CreateIndex(
                name: "IX_SveOAutomobilima_KubikazaId",
                table: "SveOAutomobilima",
                column: "KubikazaId");

            migrationBuilder.CreateIndex(
                name: "IX_SveOAutomobilima_KwksId",
                table: "SveOAutomobilima",
                column: "KwksId");

            migrationBuilder.CreateIndex(
                name: "IX_SveOAutomobilima_OpremaId",
                table: "SveOAutomobilima",
                column: "OpremaId");

            migrationBuilder.CreateIndex(
                name: "IX_SveOAutomobilima_PogonId",
                table: "SveOAutomobilima",
                column: "PogonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SveOAutomobilima");
        }
    }
}
