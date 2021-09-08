using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol506 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ProjectLongitude",
                table: "ProjectField",
                type: "decimal(18,15)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ProjectLatitude",
                table: "ProjectField",
                type: "decimal(18,15)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,6)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "DashboardLineGraphModel",
                columns: table => new
                {
                    ProjectYear = table.Column<int>(type: "int", nullable: false),
                    NumberOfProjects = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DashboardLineGraphModel");

            migrationBuilder.AlterColumn<decimal>(
                name: "ProjectLongitude",
                table: "ProjectField",
                type: "decimal(9,6)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ProjectLatitude",
                table: "ProjectField",
                type: "decimal(9,6)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,15)",
                oldNullable: true);
        }
    }
}
