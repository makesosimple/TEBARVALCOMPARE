using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class UserForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "City",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_City_UserID",
                table: "City",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_City_AspNetUsers_UserID",
                table: "City",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_AspNetUsers_UserID",
                table: "City");

            migrationBuilder.DropIndex(
                name: "IX_City_UserID",
                table: "City");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "City");
        }
    }
}
