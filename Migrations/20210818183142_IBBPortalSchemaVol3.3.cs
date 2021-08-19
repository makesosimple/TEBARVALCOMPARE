using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectBoardApproval",
                columns: table => new
                {
                    ProjectBoardApprovalID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: true),
                    IsBoardApprovalNeeded = table.Column<bool>(type: "bit", nullable: false),
                    BoardID = table.Column<int>(type: "int", nullable: true),
                    ProjectBoardApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProjectBoardApprovalReason = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectBoardApproval", x => x.ProjectBoardApprovalID);
                    table.ForeignKey(
                        name: "FK_ProjectBoardApproval_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectBoardApproval_Board_BoardID",
                        column: x => x.BoardID,
                        principalTable: "Board",
                        principalColumn: "BoardID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectBoardApproval_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectExpropriation",
                columns: table => new
                {
                    ProjectExpropriationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: true),
                    ProjectExpropriationDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ProjectNeedsExpropriation = table.Column<bool>(type: "bit", nullable: false),
                    ProjectExpropriationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProjectExpropriationCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProjectExpropriationStatusDesc = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectExpropriation", x => x.ProjectExpropriationID);
                    table.ForeignKey(
                        name: "FK_ProjectExpropriation_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectExpropriation_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectPermission",
                columns: table => new
                {
                    ProjectPermissionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: true),
                    IsPermissionNeeded = table.Column<bool>(type: "bit", nullable: false),
                    ProjectPermissionProvider = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ProjectPermissionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProjectPermissionReason = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectPermission", x => x.ProjectPermissionID);
                    table.ForeignKey(
                        name: "FK_ProjectPermission_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectZoningPlan",
                columns: table => new
                {
                    ProjectZoningPlanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: true),
                    ZoningPlanStatusID1000 = table.Column<int>(type: "int", nullable: true),
                    ZoningPlanDate1000 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ZoningPlanStatusID5000 = table.Column<int>(type: "int", nullable: true),
                    ZoningPlanDate5000 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ZoningPlanModificationNeeded = table.Column<bool>(type: "bit", nullable: false),
                    ZoningPlanModificationReason = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ModificationApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModificationProposalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ZoningPlanModificationStatusID = table.Column<int>(type: "int", nullable: true),
                    ZoningPlanResponsiblePersonID = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectZoningPlan", x => x.ProjectZoningPlanID);
                    table.ForeignKey(
                        name: "FK_ProjectZoningPlan_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectZoningPlan_Person_ZoningPlanResponsiblePersonID",
                        column: x => x.ZoningPlanResponsiblePersonID,
                        principalTable: "Person",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectZoningPlan_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectZoningPlan_ZoningPlanModificationStatus_ZoningPlanModificationStatusID",
                        column: x => x.ZoningPlanModificationStatusID,
                        principalTable: "ZoningPlanModificationStatus",
                        principalColumn: "ZoningPlanModificationStatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectZoningPlan_ZoningPlanStatus_ZoningPlanStatusID1000",
                        column: x => x.ZoningPlanStatusID1000,
                        principalTable: "ZoningPlanStatus",
                        principalColumn: "ZoningPlanStatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectZoningPlan_ZoningPlanStatus_ZoningPlanStatusID5000",
                        column: x => x.ZoningPlanStatusID5000,
                        principalTable: "ZoningPlanStatus",
                        principalColumn: "ZoningPlanStatusID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBoardApproval_BoardID",
                table: "ProjectBoardApproval",
                column: "BoardID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBoardApproval_ProjectID",
                table: "ProjectBoardApproval",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBoardApproval_UserID",
                table: "ProjectBoardApproval",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectExpropriation_ProjectID",
                table: "ProjectExpropriation",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectExpropriation_UserID",
                table: "ProjectExpropriation",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPermission_ProjectID",
                table: "ProjectPermission",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectZoningPlan_ProjectID",
                table: "ProjectZoningPlan",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectZoningPlan_UserID",
                table: "ProjectZoningPlan",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectZoningPlan_ZoningPlanModificationStatusID",
                table: "ProjectZoningPlan",
                column: "ZoningPlanModificationStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectZoningPlan_ZoningPlanResponsiblePersonID",
                table: "ProjectZoningPlan",
                column: "ZoningPlanResponsiblePersonID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectZoningPlan_ZoningPlanStatusID1000",
                table: "ProjectZoningPlan",
                column: "ZoningPlanStatusID1000");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectZoningPlan_ZoningPlanStatusID5000",
                table: "ProjectZoningPlan",
                column: "ZoningPlanStatusID5000");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectBoardApproval");

            migrationBuilder.DropTable(
                name: "ProjectExpropriation");

            migrationBuilder.DropTable(
                name: "ProjectPermission");

            migrationBuilder.DropTable(
                name: "ProjectZoningPlan");
        }
    }
}
