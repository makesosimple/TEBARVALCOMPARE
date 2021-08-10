using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ProjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTitle = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ProjectCode = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    ProjectIBBCode = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    RequestingManagementID = table.Column<int>(type: "int", nullable: false),
                    ResponsibleManagementID = table.Column<int>(type: "int", nullable: false),
                    ProjectOwnerPersonID = table.Column<int>(type: "int", nullable: false),
                    ProjectServiceAreaID = table.Column<int>(type: "int", nullable: false),
                    ProjectImportanceID = table.Column<int>(type: "int", nullable: false),
                    ProjectStatusID = table.Column<int>(type: "int", nullable: false),
                    ProjectStatusDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ProjectStatusDescriptionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsFeasibilityNeeded = table.Column<bool>(type: "bit", nullable: false),
                    HasRelatedProject = table.Column<bool>(type: "bit", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ProjectID);
                    table.ForeignKey(
                        name: "FK_Project_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Project_Management_RequestingManagementID",
                        column: x => x.RequestingManagementID,
                        principalTable: "Management",
                        principalColumn: "ManagementID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Project_Management_ResponsibleManagementID",
                        column: x => x.ResponsibleManagementID,
                        principalTable: "Management",
                        principalColumn: "ManagementID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Project_Person_ProjectOwnerPersonID",
                        column: x => x.ProjectOwnerPersonID,
                        principalTable: "Person",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Project_ProjectImportance_ProjectImportanceID",
                        column: x => x.ProjectImportanceID,
                        principalTable: "ProjectImportance",
                        principalColumn: "ProjectImportanceID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Project_ProjectStatus_ProjectStatusID",
                        column: x => x.ProjectStatusID,
                        principalTable: "ProjectStatus",
                        principalColumn: "ProjectStatusID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Project_ServiceArea_ProjectServiceAreaID",
                        column: x => x.ProjectServiceAreaID,
                        principalTable: "ServiceArea",
                        principalColumn: "ServiceAreaID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectImportanceID",
                table: "Project",
                column: "ProjectImportanceID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectOwnerPersonID",
                table: "Project",
                column: "ProjectOwnerPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectServiceAreaID",
                table: "Project",
                column: "ProjectServiceAreaID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectStatusID",
                table: "Project",
                column: "ProjectStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_RequestingManagementID",
                table: "Project",
                column: "RequestingManagementID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ResponsibleManagementID",
                table: "Project",
                column: "ResponsibleManagementID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_UserID",
                table: "Project",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
