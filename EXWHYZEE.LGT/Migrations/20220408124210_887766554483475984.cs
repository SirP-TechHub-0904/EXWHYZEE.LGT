using Microsoft.EntityFrameworkCore.Migrations;

namespace EXWHYZEE.LGT.Migrations
{
    public partial class _887766554483475984 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_LocalGovernments_LocalGovernmentId",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Sections_LocalGovernmentId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "LocalGovernmentId",
                table: "Sections");

            migrationBuilder.AddColumn<long>(
                name: "CategoryId",
                table: "Sections",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<string>(
                name: "Populations",
                table: "Communities",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Male",
                table: "Communities",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Female",
                table: "Communities",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Categories",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sections_CategoryId",
                table: "Sections",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Categories_CategoryId",
                table: "Sections",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Categories_CategoryId",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Sections_CategoryId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Categories");

            migrationBuilder.AddColumn<long>(
                name: "LocalGovernmentId",
                table: "Sections",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<int>(
                name: "Populations",
                table: "Communities",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Male",
                table: "Communities",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Female",
                table: "Communities",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sections_LocalGovernmentId",
                table: "Sections",
                column: "LocalGovernmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_LocalGovernments_LocalGovernmentId",
                table: "Sections",
                column: "LocalGovernmentId",
                principalTable: "LocalGovernments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
