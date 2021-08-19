using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol343 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExpropriationStatusID",
                table: "ProjectExpropriation",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ExpropriationStatus",
                columns: table => new
                {
                    ExpropriationStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpropriationStatusTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ExpropriationStatusDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpropriationStatus", x => x.ExpropriationStatusID);
                    table.ForeignKey(
                        name: "FK_ExpropriationStatus_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectExpropriation_ExpropriationStatusID",
                table: "ProjectExpropriation",
                column: "ExpropriationStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_ExpropriationStatus_UserID",
                table: "ExpropriationStatus",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectExpropriation_ExpropriationStatus_ExpropriationStatusID",
                table: "ProjectExpropriation",
                column: "ExpropriationStatusID",
                principalTable: "ExpropriationStatus",
                principalColumn: "ExpropriationStatusID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectExpropriation_ExpropriationStatus_ExpropriationStatusID",
                table: "ProjectExpropriation");

            migrationBuilder.DropTable(
                name: "ExpropriationStatus");

            migrationBuilder.DropIndex(
                name: "IX_ProjectExpropriation_ExpropriationStatusID",
                table: "ProjectExpropriation");

            migrationBuilder.DropColumn(
                name: "ExpropriationStatusID",
                table: "ProjectExpropriation");
        }
    }
}
