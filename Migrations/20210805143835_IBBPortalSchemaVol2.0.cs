using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_District_AspNetUsers_UserID",
                table: "District");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "District",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentTitle = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ParentDepartmentID = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentID);
                    table.ForeignKey(
                        name: "FK_Department_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Department_Department_ParentDepartmentID",
                        column: x => x.ParentDepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FileCategory",
                columns: table => new
                {
                    FileCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileCategoryTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FileCategoryFolderName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FileCategoryDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ParentFileCategoryID = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileCategory", x => x.FileCategoryID);
                    table.ForeignKey(
                        name: "FK_FileCategory_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FileCategory_FileCategory_ParentFileCategoryID",
                        column: x => x.ParentFileCategoryID,
                        principalTable: "FileCategory",
                        principalColumn: "FileCategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Management",
                columns: table => new
                {
                    ManagementID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManagementTitle = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ManagementDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    TaxCode = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Management", x => x.ManagementID);
                    table.ForeignKey(
                        name: "FK_Management_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Phase",
                columns: table => new
                {
                    PhaseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhaseTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhaseDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PreviousPhaseID = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phase", x => x.PhaseID);
                    table.ForeignKey(
                        name: "FK_Phase_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectPhaseStatus",
                columns: table => new
                {
                    ProjectPhaseStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectPhaseStatusTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProjectPhaseStatusDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectPhaseStatus", x => x.ProjectPhaseStatusID);
                    table.ForeignKey(
                        name: "FK_ProjectPhaseStatus_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectStatus",
                columns: table => new
                {
                    ProjectStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectStatusTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProjectStatusDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectStatus", x => x.ProjectStatusID);
                    table.ForeignKey(
                        name: "FK_ProjectStatus_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTeamCategory",
                columns: table => new
                {
                    ProjectTeamCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTeamCategoryTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProjectTeamCategoryDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTeamCategory", x => x.ProjectTeamCategoryID);
                    table.ForeignKey(
                        name: "FK_ProjectTeamCategory_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceArea",
                columns: table => new
                {
                    ServiceAreaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceAreaTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ServiceAreaDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ParentServiceAreaID = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceArea", x => x.ServiceAreaID);
                    table.ForeignKey(
                        name: "FK_ServiceArea_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceArea_ServiceArea_ParentServiceAreaID",
                        column: x => x.ParentServiceAreaID,
                        principalTable: "ServiceArea",
                        principalColumn: "ServiceAreaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subfunction",
                columns: table => new
                {
                    SubfunctionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubfunctionTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubfunctionDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subfunction", x => x.SubfunctionID);
                    table.ForeignKey(
                        name: "FK_Subfunction_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ZoningPlanStatus",
                columns: table => new
                {
                    ZoningPlanStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZoningPlanStatusTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZoningPlanStatus", x => x.ZoningPlanStatusID);
                    table.ForeignKey(
                        name: "FK_ZoningPlanStatus_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_Department_ParentDepartmentID",
                table: "Department",
                column: "ParentDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Department_UserID",
                table: "Department",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_FileCategory_ParentFileCategoryID",
                table: "FileCategory",
                column: "ParentFileCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_FileCategory_UserID",
                table: "FileCategory",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Management_UserID",
                table: "Management",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Phase_UserID",
                table: "Phase",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPhaseStatus_UserID",
                table: "ProjectPhaseStatus",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectStatus_UserID",
                table: "ProjectStatus",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTeamCategory_UserID",
                table: "ProjectTeamCategory",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceArea_ParentServiceAreaID",
                table: "ServiceArea",
                column: "ParentServiceAreaID");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceArea_UserID",
                table: "ServiceArea",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Subfunction_UserID",
                table: "Subfunction",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_SubfunctionFeature_SubfunctionID",
                table: "SubfunctionFeature",
                column: "SubfunctionID");

            migrationBuilder.CreateIndex(
                name: "IX_SubfunctionFeature_UserID",
                table: "SubfunctionFeature",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ZoningPlanStatus_UserID",
                table: "ZoningPlanStatus",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_District_AspNetUsers_UserID",
                table: "District",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_District_AspNetUsers_UserID",
                table: "District");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "FileCategory");

            migrationBuilder.DropTable(
                name: "Management");

            migrationBuilder.DropTable(
                name: "Phase");

            migrationBuilder.DropTable(
                name: "ProjectPhaseStatus");

            migrationBuilder.DropTable(
                name: "ProjectStatus");

            migrationBuilder.DropTable(
                name: "ProjectTeamCategory");

            migrationBuilder.DropTable(
                name: "ServiceArea");

            migrationBuilder.DropTable(
                name: "SubfunctionFeature");

            migrationBuilder.DropTable(
                name: "ZoningPlanStatus");

            migrationBuilder.DropTable(
                name: "Subfunction");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "District",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_District_AspNetUsers_UserID",
                table: "District",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
