using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EXWHYZEE.LGT.Migrations
{
    public partial class _00115765676543 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LGA",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StateofOrigin",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "LandMass",
                table: "LocalGovernments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Latitude",
                table: "LocalGovernments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Longitude",
                table: "LocalGovernments",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CommunitiesId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CommunitytId",
                table: "AspNetUsers",
                nullable: true,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LocalGovernmentId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "StateId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Communities",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    LandMass = table.Column<string>(nullable: true),
                    Populations = table.Column<int>(nullable: false),
                    Male = table.Column<int>(nullable: false),
                    Female = table.Column<int>(nullable: false),
                    SelfEmployed = table.Column<string>(nullable: true),
                    Employed = table.Column<string>(nullable: true),
                    UnEmployed = table.Column<string>(nullable: true),
                    LocalGovernmentId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Communities_LocalGovernments_LocalGovernmentId",
                        column: x => x.LocalGovernmentId,
                        principalTable: "LocalGovernments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommunityExecutives",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    CommunityId = table.Column<long>(nullable: false),
                    Position = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunityExecutives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommunityExecutives_Communities_CommunityId",
                        column: x => x.CommunityId,
                        principalTable: "Communities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommunityExecutives_IdentityUser_UserId",
                        column: x => x.UserId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MineralResources",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommunityId = table.Column<long>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MineralResources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MineralResources_Communities_CommunityId",
                        column: x => x.CommunityId,
                        principalTable: "Communities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CommunitiesId",
                table: "AspNetUsers",
                column: "CommunitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_LocalGovernmentId",
                table: "AspNetUsers",
                column: "LocalGovernmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_StateId",
                table: "AspNetUsers",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Communities_LocalGovernmentId",
                table: "Communities",
                column: "LocalGovernmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityExecutives_CommunityId",
                table: "CommunityExecutives",
                column: "CommunityId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityExecutives_UserId",
                table: "CommunityExecutives",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MineralResources_CommunityId",
                table: "MineralResources",
                column: "CommunityId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Communities_CommunitiesId",
                table: "AspNetUsers",
                column: "CommunitiesId",
                principalTable: "Communities",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_LocalGovernments_LocalGovernmentId",
                table: "AspNetUsers",
                column: "LocalGovernmentId",
                principalTable: "LocalGovernments",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_States_StateId",
                table: "AspNetUsers",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Communities_CommunitiesId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_LocalGovernments_LocalGovernmentId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_States_StateId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CommunityExecutives");

            migrationBuilder.DropTable(
                name: "MineralResources");

            migrationBuilder.DropTable(
                name: "Communities");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CommunitiesId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_LocalGovernmentId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_StateId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LandMass",
                table: "LocalGovernments");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "LocalGovernments");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "LocalGovernments");

            migrationBuilder.DropColumn(
                name: "CommunitiesId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CommunitytId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LocalGovernmentId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "LGA",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StateofOrigin",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
