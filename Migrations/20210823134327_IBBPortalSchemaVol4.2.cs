using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol42 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectSubfunctionFeature",
                columns: table => new
                {
                    ProjectSubfunctionFeatureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: true),
                    SubfunctionID = table.Column<int>(type: "int", nullable: true),
                    SubfunctionFeatureID = table.Column<int>(type: "int", nullable: true),
                    SubfunctionFeatureValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubfunctionFeatureValueDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectSubfunctionFeature", x => x.ProjectSubfunctionFeatureID);
                    table.ForeignKey(
                        name: "FK_ProjectSubfunctionFeature_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectSubfunctionFeature_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectSubfunctionFeature_Subfunction_SubfunctionID",
                        column: x => x.SubfunctionID,
                        principalTable: "Subfunction",
                        principalColumn: "SubfunctionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectSubfunctionFeature_SubfunctionFeature_SubfunctionFeatureID",
                        column: x => x.SubfunctionFeatureID,
                        principalTable: "SubfunctionFeature",
                        principalColumn: "SubfunctionFeatureID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSubfunctionFeature_ProjectID",
                table: "ProjectSubfunctionFeature",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSubfunctionFeature_SubfunctionFeatureID",
                table: "ProjectSubfunctionFeature",
                column: "SubfunctionFeatureID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSubfunctionFeature_SubfunctionID",
                table: "ProjectSubfunctionFeature",
                column: "SubfunctionID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSubfunctionFeature_UserID",
                table: "ProjectSubfunctionFeature",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectSubfunctionFeature");
        }
    }
}
