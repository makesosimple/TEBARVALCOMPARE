using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol55 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectSettings",
                columns: table => new
                {
                    ProjectSettingsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    HideOrShow = table.Column<bool>(type: "bit", nullable: false),
                    ProjectObjectID = table.Column<int>(type: "int", nullable: true),
                    ProjectUID = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ProjectGlobalID = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ProjectFileNumber = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ProjectPackageNumber = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectSettings", x => x.ProjectSettingsID);
                    table.ForeignKey(
                        name: "FK_ProjectSettings_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectSettings_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSettings_ProjectID",
                table: "ProjectSettings",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSettings_UserID",
                table: "ProjectSettings",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectSettings");
        }
    }
}
