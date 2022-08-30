using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LIBRARY.EXWHYZEE.LGT.Migrations
{
    public partial class trt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Indicators_LocalGovernments_LocalGovernmentId",
                table: "Indicators");

            migrationBuilder.DropIndex(
                name: "IX_Indicators_LocalGovernmentId",
                table: "Indicators");

            migrationBuilder.DropColumn(
                name: "DataSource",
                table: "Indicators");

            migrationBuilder.DropColumn(
                name: "IndicatorSymbol",
                table: "Indicators");

            migrationBuilder.DropColumn(
                name: "IndicatorValue",
                table: "Indicators");

            migrationBuilder.DropColumn(
                name: "LocalGovernmentId",
                table: "Indicators");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Indicators");

            migrationBuilder.DropColumn(
                name: "PeriodInYear",
                table: "Indicators");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Indicators");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Indicators");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Indicators",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Indicators",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Indicators",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "IndicatorDatas",
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
                    IndicatorId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndicatorDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndicatorDatas_Indicators_IndicatorId",
                        column: x => x.IndicatorId,
                        principalTable: "Indicators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndicatorDatas_LocalGovernments_LocalGovernmentId",
                        column: x => x.LocalGovernmentId,
                        principalTable: "LocalGovernments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndicatorDatas_IndicatorId",
                table: "IndicatorDatas",
                column: "IndicatorId");

            migrationBuilder.CreateIndex(
                name: "IX_IndicatorDatas_LocalGovernmentId",
                table: "IndicatorDatas",
                column: "LocalGovernmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndicatorDatas");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Indicators");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Indicators");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Indicators");

            migrationBuilder.AddColumn<string>(
                name: "DataSource",
                table: "Indicators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IndicatorSymbol",
                table: "Indicators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IndicatorValue",
                table: "Indicators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LocalGovernmentId",
                table: "Indicators",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Indicators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PeriodInYear",
                table: "Indicators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "Indicators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Year",
                table: "Indicators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Indicators_LocalGovernmentId",
                table: "Indicators",
                column: "LocalGovernmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Indicators_LocalGovernments_LocalGovernmentId",
                table: "Indicators",
                column: "LocalGovernmentId",
                principalTable: "LocalGovernments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
