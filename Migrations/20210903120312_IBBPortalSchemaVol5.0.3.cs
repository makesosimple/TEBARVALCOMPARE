using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol503 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ProjectEndTime",
                table: "Project",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectFileNumber",
                table: "Project",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectGlobalID",
                table: "Project",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectManagerID",
                table: "Project",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectObjectID",
                table: "Project",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectPackageNumber",
                table: "Project",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ProjectProductionEndTime",
                table: "Project",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectProductionName",
                table: "Project",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectProductionRespDepartmentID",
                table: "Project",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectUID",
                table: "Project",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectYear",
                table: "Project",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectManagerID",
                table: "Project",
                column: "ProjectManagerID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectProductionRespDepartmentID",
                table: "Project",
                column: "ProjectProductionRespDepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Department_ProjectProductionRespDepartmentID",
                table: "Project",
                column: "ProjectProductionRespDepartmentID",
                principalTable: "Department",
                principalColumn: "DepartmentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Person_ProjectManagerID",
                table: "Project",
                column: "ProjectManagerID",
                principalTable: "Person",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Department_ProjectProductionRespDepartmentID",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_Person_ProjectManagerID",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Project_ProjectManagerID",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Project_ProjectProductionRespDepartmentID",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectEndTime",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectFileNumber",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectGlobalID",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectManagerID",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectObjectID",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectPackageNumber",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectProductionEndTime",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectProductionName",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectProductionRespDepartmentID",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectUID",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectYear",
                table: "Project");
        }
    }
}
