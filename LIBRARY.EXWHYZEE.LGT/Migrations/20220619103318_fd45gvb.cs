using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LIBRARY.EXWHYZEE.LGT.Migrations
{
    public partial class fd45gvb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentLetter",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AuthorizationRole",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BodyStructure",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmploymentDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FullContactAdress",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Rank",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SalaryAccountBank",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ValidIdCard",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Passport",
                table: "AspNetUsers",
                newName: "PassPort");

            migrationBuilder.AddColumn<DateTime>(
                name: "AppointmentDate",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "BVN",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactAddress",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateRegistration",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "EmergencyContactEmail",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmergencyContactName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmergencyContactPhone",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdCardNumber",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdCardType",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdCardUpload",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastPromotionDate",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastQualification",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastQualificationYear",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LetterOfAppointment",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatus",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MethodOfLastPromotion",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherMaidenName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NextKinAddress",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NextKinEmail",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NextKinName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NextKinOccupation",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NextKinPhone",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NextKinRelationship",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SalaryBankName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpouseName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StateOfBirth",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatesVisited",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalChildren",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BVN",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ContactAddress",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateRegistration",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmergencyContactEmail",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmergencyContactName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmergencyContactPhone",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IdCardNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IdCardType",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IdCardUpload",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastPromotionDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastQualification",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastQualificationYear",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LetterOfAppointment",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MethodOfLastPromotion",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MotherMaidenName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NextKinAddress",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NextKinEmail",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NextKinName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NextKinOccupation",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NextKinPhone",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NextKinRelationship",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SalaryBankName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SpouseName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StatesVisited",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TotalChildren",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "PassPort",
                table: "AspNetUsers",
                newName: "Passport");

            migrationBuilder.AddColumn<string>(
                name: "AppointmentLetter",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorizationRole",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BodyStructure",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EmploymentDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FullContactAdress",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Height",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rank",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SalaryAccountBank",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ValidIdCard",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Weight",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
