using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol231 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "ProjectImportance",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectImportance_UserID",
                table: "ProjectImportance",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectImportance_AspNetUsers_UserID",
                table: "ProjectImportance",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectImportance_AspNetUsers_UserID",
                table: "ProjectImportance");

            migrationBuilder.DropIndex(
                name: "IX_ProjectImportance_UserID",
                table: "ProjectImportance");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "ProjectImportance");
        }
    }
}
