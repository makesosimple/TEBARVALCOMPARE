using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol501 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Role",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionDate",
                table: "Role",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Role",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Role",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Role_UserID",
                table: "Role",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Role_User_UserID",
                table: "Role",
                column: "UserID",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Role_User_UserID",
                table: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Role_UserID",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "DeletionDate",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Role");
        }
    }
}
