using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol43 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectPhase",
                columns: table => new
                {
                    ProjectPhaseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: true),
                    PhaseID = table.Column<int>(type: "int", nullable: true),
                    ProjectPhaseStatusID = table.Column<int>(type: "int", nullable: true),
                    ProjectPhaseStatusDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ProjectPhaseStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProjectPhaseFinish = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProjectPhaseRecordedStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProjectPhaseRecordedFinish = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProjectPhaseTimeExtension = table.Column<int>(type: "int", nullable: true),
                    ProjectPhaseTimeExtentedFinish = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProjectPhaseExtensionReason = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectPhase", x => x.ProjectPhaseID);
                    table.ForeignKey(
                        name: "FK_ProjectPhase_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectPhase_Phase_PhaseID",
                        column: x => x.PhaseID,
                        principalTable: "Phase",
                        principalColumn: "PhaseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectPhase_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectPhase_ProjectPhaseStatus_ProjectPhaseStatusID",
                        column: x => x.ProjectPhaseStatusID,
                        principalTable: "ProjectPhaseStatus",
                        principalColumn: "ProjectPhaseStatusID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPhase_PhaseID",
                table: "ProjectPhase",
                column: "PhaseID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPhase_ProjectID",
                table: "ProjectPhase",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPhase_ProjectPhaseStatusID",
                table: "ProjectPhase",
                column: "ProjectPhaseStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPhase_UserID",
                table: "ProjectPhase",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectPhase");
        }
    }
}
