using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol321 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "ProjectAddress",
                table: "Project",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectArea",
                table: "Project",
                type: "decimal(8,4)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectConstructionArea",
                table: "Project",
                type: "decimal(8,4)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectCost",
                table: "Project",
                type: "decimal(12,4)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectPaftaAdaParsel",
                table: "Project",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectPaysageArea",
                table: "Project",
                type: "decimal(8,4)",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "ProjectPaftaAdaParsel",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectPaysageArea",
                table: "Project");
        }
    }
}
