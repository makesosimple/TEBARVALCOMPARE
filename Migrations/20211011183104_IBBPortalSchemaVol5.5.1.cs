using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol551 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectFileNumber",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectGlobalID",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectObjectID",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectPackageNumber",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectUID",
                table: "Project");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "ProjectUID",
                table: "Project",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);
        }
    }
}
