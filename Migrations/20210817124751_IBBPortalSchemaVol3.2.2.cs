using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol322 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "ProjectPaysageArea",
                table: "Project",
                type: "float",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ProjectCost",
                table: "Project",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "ProjectConstructionArea",
                table: "Project",
                type: "float",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "ProjectArea",
                table: "Project",
                type: "float",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,4)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KML",
                table: "Project",
                type: "nvarchar(512)",
                maxLength: 512,
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

            migrationBuilder.AddColumn<Point>(
                name: "ProjectPoint",
                table: "Project",
                type: "geography",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KML",
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
                name: "ProjectPoint",
                table: "Project");

            migrationBuilder.AlterColumn<decimal>(
                name: "ProjectPaysageArea",
                table: "Project",
                type: "decimal(8,4)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ProjectCost",
                table: "Project",
                type: "decimal(12,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ProjectConstructionArea",
                table: "Project",
                type: "decimal(8,4)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ProjectArea",
                table: "Project",
                type: "decimal(8,4)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);
        }
    }
}
