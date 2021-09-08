using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol507 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "ProjectField",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectField_CityID",
                table: "ProjectField",
                column: "CityID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectField_City_CityID",
                table: "ProjectField",
                column: "CityID",
                principalTable: "City",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectField_City_CityID",
                table: "ProjectField");

            migrationBuilder.DropIndex(
                name: "IX_ProjectField_CityID",
                table: "ProjectField");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "ProjectField");
        }
    }
}
