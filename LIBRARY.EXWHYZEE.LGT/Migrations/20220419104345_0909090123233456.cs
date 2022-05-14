using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LIBRARY.EXWHYZEE.LGT.Migrations
{
    public partial class _0909090123233456 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LgaDisbusements",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocalGovernmentId = table.Column<long>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    DateReceived = table.Column<string>(nullable: true),
                    Duration = table.Column<int>(nullable: false),
                    ApprovalNote = table.Column<string>(nullable: true),
                    ApprovalStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LgaDisbusements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LgaDisbusements_LocalGovernments_LocalGovernmentId",
                        column: x => x.LocalGovernmentId,
                        principalTable: "LocalGovernments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LgaDisbusementBreakdowns",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ApprovalNote = table.Column<string>(nullable: true),
                    ApprovalStatus = table.Column<bool>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    DateReceived = table.Column<string>(nullable: true),
                    Duration = table.Column<int>(nullable: false),
                    LgaDisbusementId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LgaDisbusementBreakdowns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LgaDisbusementBreakdowns_LgaDisbusements_LgaDisbusementId",
                        column: x => x.LgaDisbusementId,
                        principalTable: "LgaDisbusements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LgaDisbusementBreakdowns_LgaDisbusementId",
                table: "LgaDisbusementBreakdowns",
                column: "LgaDisbusementId");

            migrationBuilder.CreateIndex(
                name: "IX_LgaDisbusements_LocalGovernmentId",
                table: "LgaDisbusements",
                column: "LocalGovernmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LgaDisbusementBreakdowns");

            migrationBuilder.DropTable(
                name: "LgaDisbusements");
        }
    }
}
