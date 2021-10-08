using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol531 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectAdditionalServiceAreaID",
                table: "Project",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectProductionStatusDescription",
                table: "Project",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectProductionStatusID",
                table: "Project",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectTypeID",
                table: "Project",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequestingAuthorityDescription",
                table: "Project",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RespDepartmentTransferDate",
                table: "Project",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectAdditionalServiceAreaID",
                table: "Project",
                column: "ProjectAdditionalServiceAreaID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectProductionStatusID",
                table: "Project",
                column: "ProjectProductionStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectTypeID",
                table: "Project",
                column: "ProjectTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_ProjectStatus_ProjectProductionStatusID",
                table: "Project",
                column: "ProjectProductionStatusID",
                principalTable: "ProjectStatus",
                principalColumn: "ProjectStatusID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_ProjectType_ProjectTypeID",
                table: "Project",
                column: "ProjectTypeID",
                principalTable: "ProjectType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_ServiceArea_ProjectAdditionalServiceAreaID",
                table: "Project",
                column: "ProjectAdditionalServiceAreaID",
                principalTable: "ServiceArea",
                principalColumn: "ServiceAreaID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_ProjectStatus_ProjectProductionStatusID",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_ProjectType_ProjectTypeID",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_ServiceArea_ProjectAdditionalServiceAreaID",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Project_ProjectAdditionalServiceAreaID",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Project_ProjectProductionStatusID",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Project_ProjectTypeID",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectAdditionalServiceAreaID",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectProductionStatusDescription",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectProductionStatusID",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectTypeID",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "RequestingAuthorityDescription",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "RespDepartmentTransferDate",
                table: "Project");
        }
    }
}
