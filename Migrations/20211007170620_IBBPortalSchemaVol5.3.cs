using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol53 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectBidding_Department_DepartmentID",
                table: "ProjectBidding");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionMessages_TransactionTypes_TransactionTypeID",
                table: "TransactionMessages");

            migrationBuilder.AlterColumn<int>(
                name: "TransactionTypeID",
                table: "TransactionMessages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "ProjectBidding",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "ProjectType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectType_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectType_UserID",
                table: "ProjectType",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectBidding_Department_DepartmentID",
                table: "ProjectBidding",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "DepartmentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionMessages_TransactionTypes_TransactionTypeID",
                table: "TransactionMessages",
                column: "TransactionTypeID",
                principalTable: "TransactionTypes",
                principalColumn: "TransactionTypeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectBidding_Department_DepartmentID",
                table: "ProjectBidding");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionMessages_TransactionTypes_TransactionTypeID",
                table: "TransactionMessages");

            migrationBuilder.DropTable(
                name: "ProjectType");

            migrationBuilder.AlterColumn<int>(
                name: "TransactionTypeID",
                table: "TransactionMessages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "ProjectBidding",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectBidding_Department_DepartmentID",
                table: "ProjectBidding",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "DepartmentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionMessages_TransactionTypes_TransactionTypeID",
                table: "TransactionMessages",
                column: "TransactionTypeID",
                principalTable: "TransactionTypes",
                principalColumn: "TransactionTypeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
