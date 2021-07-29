using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class ModelFixup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_District_AspNetUsers_UserID",
                table: "District");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "District",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentTitle = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ParentDepartmentID = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentID);
                    table.ForeignKey(
                        name: "FK_Department_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Department_Department_ParentDepartmentID",
                        column: x => x.ParentDepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Department_ParentDepartmentID",
                table: "Department",
                column: "ParentDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Department_UserID",
                table: "Department",
                column: "UserID");

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
                name: "FK_District_AspNetUsers_UserID",
                table: "District");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "District",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_District_AspNetUsers_UserID",
                table: "District",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
