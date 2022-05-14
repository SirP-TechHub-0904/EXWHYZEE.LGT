using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EXWHYZEE.LGT.Migrations
{
    public partial class _001157656765 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Employed",
                table: "LocalGovernments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Female",
                table: "LocalGovernments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Male",
                table: "LocalGovernments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Populations",
                table: "LocalGovernments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SelfEmployed",
                table: "LocalGovernments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UnEmployed",
                table: "LocalGovernments",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LocalGovernmentId",
                table: "Categories",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "LgaStaffs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    LocalGovernmentId = table.Column<long>(nullable: false),
                    Position = table.Column<string>(nullable: true),
                    EmploymentDate = table.Column<DateTime>(nullable: false),
                    RetirementDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LgaStaffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LgaStaffs_LocalGovernments_LocalGovernmentId",
                        column: x => x.LocalGovernmentId,
                        principalTable: "LocalGovernments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LgaStaffs_IdentityUser_UserId",
                        column: x => x.UserId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_LocalGovernmentId",
                table: "Categories",
                column: "LocalGovernmentId");

            migrationBuilder.CreateIndex(
                name: "IX_LgaStaffs_LocalGovernmentId",
                table: "LgaStaffs",
                column: "LocalGovernmentId");

            migrationBuilder.CreateIndex(
                name: "IX_LgaStaffs_UserId",
                table: "LgaStaffs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_LocalGovernments_LocalGovernmentId",
                table: "Categories",
                column: "LocalGovernmentId",
                principalTable: "LocalGovernments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_LocalGovernments_LocalGovernmentId",
                table: "Categories");

            migrationBuilder.DropTable(
                name: "LgaStaffs");

            migrationBuilder.DropIndex(
                name: "IX_Categories_LocalGovernmentId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Employed",
                table: "LocalGovernments");

            migrationBuilder.DropColumn(
                name: "Female",
                table: "LocalGovernments");

            migrationBuilder.DropColumn(
                name: "Male",
                table: "LocalGovernments");

            migrationBuilder.DropColumn(
                name: "Populations",
                table: "LocalGovernments");

            migrationBuilder.DropColumn(
                name: "SelfEmployed",
                table: "LocalGovernments");

            migrationBuilder.DropColumn(
                name: "UnEmployed",
                table: "LocalGovernments");

            migrationBuilder.DropColumn(
                name: "LocalGovernmentId",
                table: "Categories");
        }
    }
}
