using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol110 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subfunction",
                columns: table => new
                {
                    SubfunctionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubfunctionTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubfunctionDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subfunction", x => x.SubfunctionID);
                    table.ForeignKey(
                        name: "FK_Subfunction_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subfunction_UserID",
                table: "Subfunction",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subfunction");
        }
    }
}
