using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol31 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectPerson",
                columns: table => new
                {
                    ProjectPersonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsInternal = table.Column<bool>(type: "bit", nullable: false),
                    ProjectID = table.Column<int>(type: "int", nullable: true),
                    PersonID = table.Column<int>(type: "int", nullable: true),
                    JobTitleID = table.Column<int>(type: "int", nullable: true),
                    JobFieldID = table.Column<int>(type: "int", nullable: true),
                    ContractorID = table.Column<int>(type: "int", nullable: true),
                    ProjectPersonDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectPerson", x => x.ProjectPersonID);
                    table.ForeignKey(
                        name: "FK_ProjectPerson_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectPerson_Contractor_ContractorID",
                        column: x => x.ContractorID,
                        principalTable: "Contractor",
                        principalColumn: "ContractorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectPerson_JobField_JobFieldID",
                        column: x => x.JobFieldID,
                        principalTable: "JobField",
                        principalColumn: "JobFieldID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectPerson_JobTitle_JobTitleID",
                        column: x => x.JobTitleID,
                        principalTable: "JobTitle",
                        principalColumn: "JobTitleID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectPerson_Person_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Person",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectPerson_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPerson_ContractorID",
                table: "ProjectPerson",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPerson_JobFieldID",
                table: "ProjectPerson",
                column: "JobFieldID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPerson_JobTitleID",
                table: "ProjectPerson",
                column: "JobTitleID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPerson_PersonID",
                table: "ProjectPerson",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPerson_ProjectID",
                table: "ProjectPerson",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPerson_UserID",
                table: "ProjectPerson",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectPerson");
        }
    }
}
