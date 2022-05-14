using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LIBRARY.EXWHYZEE.LGT.Migrations
{
    public partial class _090909012323 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpecialProjectCategory",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    DateStart = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    SortOrder = table.Column<int>(nullable: false),
                    LocalGovernmentId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialProjectCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpecialProjectCategory_LocalGovernments_LocalGovernmentId",
                        column: x => x.LocalGovernmentId,
                        principalTable: "LocalGovernments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecialProject",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    FullAddress = table.Column<string>(nullable: true),
                    DateStart = table.Column<DateTime>(nullable: false),
                    DateEnd = table.Column<DateTime>(nullable: false),
                    SpecialProjectCategoryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialProject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpecialProject_SpecialProjectCategory_SpecialProjectCategoryId",
                        column: x => x.SpecialProjectCategoryId,
                        principalTable: "SpecialProjectCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    SpecialProjectId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_SpecialProject_SpecialProjectId",
                        column: x => x.SpecialProjectId,
                        principalTable: "SpecialProject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_SpecialProjectId",
                table: "Images",
                column: "SpecialProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialProject_SpecialProjectCategoryId",
                table: "SpecialProject",
                column: "SpecialProjectCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialProjectCategory_LocalGovernmentId",
                table: "SpecialProjectCategory",
                column: "LocalGovernmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "SpecialProject");

            migrationBuilder.DropTable(
                name: "SpecialProjectCategory");
        }
    }
}
