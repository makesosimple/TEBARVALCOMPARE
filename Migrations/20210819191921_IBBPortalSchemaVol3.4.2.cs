using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol342 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_District_DistrictID",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Project_DistrictID",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "DistrictID",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "IsProjectInIstanbul",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "KML",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectAddress",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectArea",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectConstructionArea",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectCost",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectLatitude",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectLineString",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectLongitude",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectPaftaAdaParsel",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectPaysageArea",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectPoint",
                table: "Project");

            migrationBuilder.CreateTable(
                name: "ProjectField",
                columns: table => new
                {
                    ProjectFieldID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: true),
                    IsProjectInIstanbul = table.Column<bool>(type: "bit", nullable: false),
                    DistrictID = table.Column<int>(type: "int", nullable: true),
                    ProjectAddress = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ProjectCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProjectArea = table.Column<double>(type: "float", nullable: true),
                    ProjectConstructionArea = table.Column<double>(type: "float", nullable: true),
                    ProjectPaysageArea = table.Column<double>(type: "float", nullable: true),
                    ProjectPaftaAdaParsel = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    KML = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ProjectLongitude = table.Column<decimal>(type: "decimal(9,6)", nullable: true),
                    ProjectLatitude = table.Column<decimal>(type: "decimal(9,6)", nullable: true),
                    ProjectPoint = table.Column<Point>(type: "geography", nullable: true),
                    ProjectLineString = table.Column<LineString>(type: "geography", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectField", x => x.ProjectFieldID);
                    table.ForeignKey(
                        name: "FK_ProjectField_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectField_District_DistrictID",
                        column: x => x.DistrictID,
                        principalTable: "District",
                        principalColumn: "DistrictID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectField_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectField_DistrictID",
                table: "ProjectField",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectField_ProjectID",
                table: "ProjectField",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectField_UserID",
                table: "ProjectField",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectField");

            migrationBuilder.AddColumn<int>(
                name: "DistrictID",
                table: "Project",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsProjectInIstanbul",
                table: "Project",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "KML",
                table: "Project",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectAddress",
                table: "Project",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ProjectArea",
                table: "Project",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ProjectConstructionArea",
                table: "Project",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectCost",
                table: "Project",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectLatitude",
                table: "Project",
                type: "decimal(9,6)",
                nullable: true);

            migrationBuilder.AddColumn<LineString>(
                name: "ProjectLineString",
                table: "Project",
                type: "geography",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectLongitude",
                table: "Project",
                type: "decimal(9,6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectPaftaAdaParsel",
                table: "Project",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ProjectPaysageArea",
                table: "Project",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<Point>(
                name: "ProjectPoint",
                table: "Project",
                type: "geography",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Project_DistrictID",
                table: "Project",
                column: "DistrictID");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_District_DistrictID",
                table: "Project",
                column: "DistrictID",
                principalTable: "District",
                principalColumn: "DistrictID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
