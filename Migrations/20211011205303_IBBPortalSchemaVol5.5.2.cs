using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol552 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectCost",
                table: "ProjectField");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectIBBCode",
                table: "Project",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "ExternalOrganizationID",
                table: "Project",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDoneByIBB",
                table: "Project",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectCost",
                table: "Project",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsExternal",
                table: "Organization",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Project_ExternalOrganizationID",
                table: "Project",
                column: "ExternalOrganizationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Organization_ExternalOrganizationID",
                table: "Project",
                column: "ExternalOrganizationID",
                principalTable: "Organization",
                principalColumn: "OrganizationID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Organization_ExternalOrganizationID",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Project_ExternalOrganizationID",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ExternalOrganizationID",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "IsDoneByIBB",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectCost",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "IsExternal",
                table: "Organization");

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectCost",
                table: "ProjectField",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProjectIBBCode",
                table: "Project",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);
        }
    }
}
