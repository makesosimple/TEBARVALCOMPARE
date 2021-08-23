using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol41 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasRelatedProject",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "IsFeasibilityNeeded",
                table: "Project");

            migrationBuilder.CreateTable(
                name: "ProjectFeasibility",
                columns: table => new
                {
                    ProjectFeasibilityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsFeasibilityNeeded = table.Column<bool>(type: "bit", nullable: false),
                    ProjectID = table.Column<int>(type: "int", nullable: true),
                    ContractorID = table.Column<int>(type: "int", nullable: true),
                    PersonID = table.Column<int>(type: "int", nullable: true),
                    ProjectFeasibilityOutsource = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ProjectFeasibilityDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProjectFeasibilityCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectFeasibility", x => x.ProjectFeasibilityID);
                    table.ForeignKey(
                        name: "FK_ProjectFeasibility_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectFeasibility_Contractor_ContractorID",
                        column: x => x.ContractorID,
                        principalTable: "Contractor",
                        principalColumn: "ContractorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectFeasibility_Person_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Person",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectFeasibility_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectFeasibility_ContractorID",
                table: "ProjectFeasibility",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectFeasibility_PersonID",
                table: "ProjectFeasibility",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectFeasibility_ProjectID",
                table: "ProjectFeasibility",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectFeasibility_UserID",
                table: "ProjectFeasibility",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectFeasibility");

            migrationBuilder.AddColumn<bool>(
                name: "HasRelatedProject",
                table: "Project",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsFeasibilityNeeded",
                table: "Project",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
