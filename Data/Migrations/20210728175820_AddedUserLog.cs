using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class AddedUserLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "District",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Contractor",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Contractor",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Board",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_District_UserID",
                table: "District",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Contractor_UserID",
                table: "Contractor",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Board_UserID",
                table: "Board",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Board_AspNetUsers_UserID",
                table: "Board",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contractor_AspNetUsers_UserID",
                table: "Contractor",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_District_AspNetUsers_UserID",
                table: "District",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Board_AspNetUsers_UserID",
                table: "Board");

            migrationBuilder.DropForeignKey(
                name: "FK_Contractor_AspNetUsers_UserID",
                table: "Contractor");

            migrationBuilder.DropForeignKey(
                name: "FK_District_AspNetUsers_UserID",
                table: "District");

            migrationBuilder.DropIndex(
                name: "IX_District_UserID",
                table: "District");

            migrationBuilder.DropIndex(
                name: "IX_Contractor_UserID",
                table: "Contractor");

            migrationBuilder.DropIndex(
                name: "IX_Board_UserID",
                table: "Board");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "District");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Contractor");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Board");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Contractor",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
