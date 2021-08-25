using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol44 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectBidding",
                columns: table => new
                {
                    ProjectBiddingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: true),
                    BiddingTitle = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ProjectPhaseID = table.Column<int>(type: "int", nullable: true),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    BiddingCode = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    BiddingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BiddingContractCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BiddingProgressPayment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ContractorID = table.Column<int>(type: "int", nullable: true),
                    BiddingDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectBidding", x => x.ProjectBiddingID);
                    table.ForeignKey(
                        name: "FK_ProjectBidding_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectBidding_Contractor_ContractorID",
                        column: x => x.ContractorID,
                        principalTable: "Contractor",
                        principalColumn: "ContractorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectBidding_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectBidding_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectBidding_ProjectPhase_ProjectPhaseID",
                        column: x => x.ProjectPhaseID,
                        principalTable: "ProjectPhase",
                        principalColumn: "ProjectPhaseID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBidding_ContractorID",
                table: "ProjectBidding",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBidding_DepartmentID",
                table: "ProjectBidding",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBidding_ProjectID",
                table: "ProjectBidding",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBidding_ProjectPhaseID",
                table: "ProjectBidding",
                column: "ProjectPhaseID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBidding_UserID",
                table: "ProjectBidding",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectBidding");
        }
    }
}
