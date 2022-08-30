using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LIBRARY.EXWHYZEE.LGT.Migrations
{
    public partial class trtd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "IndicatorDatas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "IndicatorDatas");
        }
    }
}
