using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol54 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectProduction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: true),
                    FoundationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OpeningDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EstimatedCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ApproximateCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ContractCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ContractIncrementCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ApproximateCostDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContractStartingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContractEndingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PhysicalCompletionRatio = table.Column<int>(type: "int", nullable: true),
                    TotalProgressPaymentCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MonetaryCompletionRatio = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectProduction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectProduction_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectProduction_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProduction_ProjectID",
                table: "ProjectProduction",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProduction_UserID",
                table: "ProjectProduction",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectProduction");
        }
    }
}
