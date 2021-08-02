using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiceArea",
                columns: table => new
                {
                    ServiceAreaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceAreaTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ServiceAreaDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ParentServiceAreaID = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceArea", x => x.ServiceAreaID);
                    table.ForeignKey(
                        name: "FK_ServiceArea_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceArea_ServiceArea_ParentServiceAreaID",
                        column: x => x.ParentServiceAreaID,
                        principalTable: "ServiceArea",
                        principalColumn: "ServiceAreaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceArea_ParentServiceAreaID",
                table: "ServiceArea",
                column: "ParentServiceAreaID");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceArea_UserID",
                table: "ServiceArea",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceArea");
        }
    }
}
