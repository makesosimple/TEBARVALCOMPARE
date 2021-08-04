using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubfunctionFeature",
                columns: table => new
                {
                    SubfunctionFeatureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubfunctionFeatureTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubfunctionFeatureDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    SubfunctionMeasurementUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubfunctionID = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubfunctionFeature", x => x.SubfunctionFeatureID);
                    table.ForeignKey(
                        name: "FK_SubfunctionFeature_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubfunctionFeature_Subfunction_SubfunctionID",
                        column: x => x.SubfunctionID,
                        principalTable: "Subfunction",
                        principalColumn: "SubfunctionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubfunctionFeature_SubfunctionID",
                table: "SubfunctionFeature",
                column: "SubfunctionID");

            migrationBuilder.CreateIndex(
                name: "IX_SubfunctionFeature_UserID",
                table: "SubfunctionFeature",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubfunctionFeature");
        }
    }
}
