using Microsoft.EntityFrameworkCore.Migrations;

namespace LIBRARY.EXWHYZEE.LGT.Migrations
{
    public partial class trtdl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "IndicatorValue",
                table: "IndicatorDatas",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IndicatorValue",
                table: "IndicatorDatas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal));
        }
    }
}
