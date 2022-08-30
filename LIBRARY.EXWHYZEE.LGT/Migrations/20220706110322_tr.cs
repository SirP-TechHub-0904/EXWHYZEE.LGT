using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LIBRARY.EXWHYZEE.LGT.Migrations
{
    public partial class tr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MainIndicators",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainIndicators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubIndicators",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    MainIndicatorId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubIndicators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubIndicators_MainIndicators_MainIndicatorId",
                        column: x => x.MainIndicatorId,
                        principalTable: "MainIndicators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Indicators",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    PeriodInYear = table.Column<string>(nullable: true),
                    IndicatorSymbol = table.Column<string>(nullable: true),
                    IndicatorValue = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    LocalGovernmentId = table.Column<long>(nullable: false),
                    DataSource = table.Column<string>(nullable: true),
                    SubIndicatorId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indicators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Indicators_LocalGovernments_LocalGovernmentId",
                        column: x => x.LocalGovernmentId,
                        principalTable: "LocalGovernments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Indicators_SubIndicators_SubIndicatorId",
                        column: x => x.SubIndicatorId,
                        principalTable: "SubIndicators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Indicators_LocalGovernmentId",
                table: "Indicators",
                column: "LocalGovernmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Indicators_SubIndicatorId",
                table: "Indicators",
                column: "SubIndicatorId");

            migrationBuilder.CreateIndex(
                name: "IX_SubIndicators_MainIndicatorId",
                table: "SubIndicators",
                column: "MainIndicatorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Indicators");

            migrationBuilder.DropTable(
                name: "SubIndicators");

            migrationBuilder.DropTable(
                name: "MainIndicators");
        }
    }
}
