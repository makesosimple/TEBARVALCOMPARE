using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bidding",
                columns: table => new
                {
                    BiddingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    ProjectPhaseID = table.Column<int>(type: "int", nullable: false),
                    BiddingCode = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    BiddingTitle = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    BiddingDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    BiddingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BiddingContractCost = table.Column<decimal>(type: "decimal(12,4)", nullable: false),
                    BiddingProgressPayment = table.Column<decimal>(type: "decimal(12,4)", nullable: false),
                    ContractorID = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bidding", x => x.BiddingID);
                });

            migrationBuilder.CreateTable(
                name: "Board",
                columns: table => new
                {
                    BoardID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoardTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BoardDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Board", x => x.BoardID);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityCode = table.Column<int>(type: "int", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityID);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentTitle = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    ParentDepartmentID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    DistrictID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictCode = table.Column<int>(type: "int", nullable: false),
                    DistrictName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.DistrictID);
                });

            migrationBuilder.CreateTable(
                name: "File",
                columns: table => new
                {
                    FileID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    FileCategoryID = table.Column<int>(type: "int", nullable: false),
                    BiddingID = table.Column<int>(type: "int", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    FileType = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    FileURL = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    FileStatus = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_File", x => x.FileID);
                });

            migrationBuilder.CreateTable(
                name: "JobTitle",
                columns: table => new
                {
                    FileCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileCategoryTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FileCategoryFolderName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FileCategoryDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FileCategoryParentID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitle", x => x.FileCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Management",
                columns: table => new
                {
                    ManagementID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManagementTitle = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ManagementDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    TaxCode = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Management", x => x.ManagementID);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PhaseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhaseTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhaseDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PreviousPhaseID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PhaseID);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ProjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectCode = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    ProjectIBBCode = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    ProjectTitle = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ProjectStatusID = table.Column<int>(type: "int", nullable: false),
                    ProjectStatusDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ProjectOwnerPersonID = table.Column<int>(type: "int", nullable: false),
                    ProjectCoordinatorPersonID = table.Column<int>(type: "int", nullable: false),
                    ServiceAreaID = table.Column<int>(type: "int", nullable: false),
                    ProjectImportanceID = table.Column<int>(type: "int", nullable: false),
                    RequestingManagementID = table.Column<int>(type: "int", nullable: false),
                    IsProjectInIstanbul = table.Column<bool>(type: "bit", nullable: false),
                    DistrictID = table.Column<int>(type: "int", nullable: false),
                    ProjectAddress = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ProjectCost = table.Column<decimal>(type: "decimal(12,4)", nullable: false),
                    ProjectArea = table.Column<decimal>(type: "decimal(8,4)", nullable: false),
                    ProjectConstructionArea = table.Column<decimal>(type: "decimal(8,4)", nullable: false),
                    ProjectPaysageArea = table.Column<decimal>(type: "decimal(8,4)", nullable: false),
                    ProjectPaftaAdaParsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectFeasibilityID = table.Column<int>(type: "int", nullable: false),
                    ProjectExpropriationID = table.Column<int>(type: "int", nullable: false),
                    ProjectZoningPlanID = table.Column<int>(type: "int", nullable: false),
                    ProjectPermissionID = table.Column<int>(type: "int", nullable: false),
                    ProjectBoardApprovalID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ProjectID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectBoardApproval",
                columns: table => new
                {
                    ProjectBoardApprovalID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    BoardID = table.Column<int>(type: "int", nullable: false),
                    ProjectBoardApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProjectBoardApprovalReason = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectBoardApproval", x => x.ProjectBoardApprovalID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectContractor",
                columns: table => new
                {
                    ProjectContractorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    ContractorID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectContractor", x => x.ProjectContractorID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectExpropriation",
                columns: table => new
                {
                    ProjectExpropriationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    ProjectExpropriationDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ProjectNeedsExpropriation = table.Column<bool>(type: "bit", nullable: false),
                    ProjectExpropriationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProjectExpropriationCost = table.Column<decimal>(type: "decimal(12,4)", nullable: false),
                    ProjectExpropriationStatusDesc = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectExpropriation", x => x.ProjectExpropriationID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectFeasibility",
                columns: table => new
                {
                    ProjectFeasibilityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    ContractorID = table.Column<int>(type: "int", nullable: false),
                    PersonID = table.Column<int>(type: "int", nullable: false),
                    ProjectFeasibilityOutsource = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectFeasibilityDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProjectFeasibilityCost = table.Column<decimal>(type: "decimal(12,4)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectFeasibility", x => x.ProjectFeasibilityID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectImportance",
                columns: table => new
                {
                    ProjectImportanceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectImportanceTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProjectImportanceDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectImportance", x => x.ProjectImportanceID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectPermission",
                columns: table => new
                {
                    ProjectPermissionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "ProjectPhase",
                columns: table => new
                {
                    ProjectPhaseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    PhaseID = table.Column<int>(type: "int", nullable: false),
                    ProjectPhaseStatusID = table.Column<int>(type: "int", nullable: false),
                    ProjectPhaseStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjectPhaseFinish = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjectPhaseStatusDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PhaseOrder = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectPhase", x => x.ProjectPhaseID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectStatus",
                columns: table => new
                {
                    ProjectStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectStatusDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectStatus", x => x.ProjectStatusID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTeamCategory",
                columns: table => new
                {
                    ProjectTeamCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTeamCategoryTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProjectTeamCategoryDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTeamCategory", x => x.ProjectTeamCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectZoningPlan",
                columns: table => new
                {
                    ProjectZoningPlanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    ZoningPlanStatus1000 = table.Column<int>(type: "int", nullable: false),
                    ZoningPlanStatus5000 = table.Column<int>(type: "int", nullable: false),
                    ZoningPlanDate1000 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ZoningPlanDate5000 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ZoningPlanModificationNeeded = table.Column<bool>(type: "bit", nullable: false),
                    ZoningPlanModificationReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModificationApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModificationProposallDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ZoningPlanModificationStatus = table.Column<int>(type: "int", nullable: false),
                    ZoningPlanResponsiblePersonID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectZoningPlan", x => x.ProjectZoningPlanID);
                });

            migrationBuilder.CreateTable(
                name: "ServiceAreas",
                columns: table => new
                {
                    ServiceAreaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceAreaTitle = table.Column<int>(type: "int", nullable: false),
                    ServiceAreaParentID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceAreas", x => x.ServiceAreaID);
                });

            migrationBuilder.CreateTable(
                name: "Shortcuts",
                columns: table => new
                {
                    ShortcutsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortcutsType = table.Column<int>(type: "int", nullable: false),
                    ShortcutsProjectID = table.Column<int>(type: "int", nullable: false),
                    ShortcutsUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shortcuts", x => x.ShortcutsID);
                });

            migrationBuilder.CreateTable(
                name: "ZoningPlanModificationStatus",
                columns: table => new
                {
                    ZoningPlanModificationStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZoningPlanModificationStatusTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZoningPlanModificationStatus", x => x.ZoningPlanModificationStatusID);
                });

            migrationBuilder.CreateTable(
                name: "ZoningPlanStatus",
                columns: table => new
                {
                    ZoningPlanStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZoningPlanStatusTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZoningPlanStatus", x => x.ZoningPlanStatusID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bidding_ContractorID",
                table: "Bidding",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_Bidding_DepartmentID",
                table: "Bidding",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Bidding_ProjectID",
                table: "Bidding",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Bidding_ProjectPhaseID",
                table: "Bidding",
                column: "ProjectPhaseID");

            migrationBuilder.CreateIndex(
                name: "IX_City_CityCode",
                table: "City",
                column: "CityCode");

            migrationBuilder.CreateIndex(
                name: "IX_Department_ParentDepartmentID",
                table: "Department",
                column: "ParentDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_District_CityID",
                table: "District",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_File_ProjectID",
                table: "File",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitle_FileCategoryParentID",
                table: "JobTitle",
                column: "FileCategoryParentID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_DistrictID",
                table: "Project",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectBoardApprovalID",
                table: "Project",
                column: "ProjectBoardApprovalID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectCoordinatorPersonID",
                table: "Project",
                column: "ProjectCoordinatorPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectExpropriationID",
                table: "Project",
                column: "ProjectExpropriationID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectFeasibilityID",
                table: "Project",
                column: "ProjectFeasibilityID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectImportanceID",
                table: "Project",
                column: "ProjectImportanceID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectStatusID",
                table: "Project",
                column: "ProjectStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectZoningPlanID",
                table: "Project",
                column: "ProjectZoningPlanID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_RequestingManagementID",
                table: "Project",
                column: "RequestingManagementID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ServiceAreaID",
                table: "Project",
                column: "ServiceAreaID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBoardApproval_ProjectID",
                table: "ProjectBoardApproval",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectContractor_ContractorID",
                table: "ProjectContractor",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectContractor_ProjectID",
                table: "ProjectContractor",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectExpropriation_ProjectID",
                table: "ProjectExpropriation",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectFeasibility_ProjectID",
                table: "ProjectFeasibility",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPermission_ProjectID",
                table: "ProjectPermission",
                column: "ProjectID");

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
                name: "IX_ProjectZoningPlan_ProjectID",
                table: "ProjectZoningPlan",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectZoningPlan_ZoningPlanModificationStatus",
                table: "ProjectZoningPlan",
                column: "ZoningPlanModificationStatus");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectZoningPlan_ZoningPlanResponsiblePersonID",
                table: "ProjectZoningPlan",
                column: "ZoningPlanResponsiblePersonID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectZoningPlan_ZoningPlanStatus1000",
                table: "ProjectZoningPlan",
                column: "ZoningPlanStatus1000");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectZoningPlan_ZoningPlanStatus5000",
                table: "ProjectZoningPlan",
                column: "ZoningPlanStatus5000");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceAreas_ServiceAreaParentID",
                table: "ServiceAreas",
                column: "ServiceAreaParentID");

            migrationBuilder.CreateIndex(
                name: "IX_Shortcuts_ShortcutsProjectID",
                table: "Shortcuts",
                column: "ShortcutsProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Shortcuts_ShortcutsUserID",
                table: "Shortcuts",
                column: "ShortcutsUserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bidding");

            migrationBuilder.DropTable(
                name: "Board");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "File");

            migrationBuilder.DropTable(
                name: "JobTitle");

            migrationBuilder.DropTable(
                name: "Management");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "ProjectBoardApproval");

            migrationBuilder.DropTable(
                name: "ProjectContractor");

            migrationBuilder.DropTable(
                name: "ProjectExpropriation");

            migrationBuilder.DropTable(
                name: "ProjectFeasibility");

            migrationBuilder.DropTable(
                name: "ProjectImportance");

            migrationBuilder.DropTable(
                name: "ProjectPermission");

            migrationBuilder.DropTable(
                name: "ProjectPhase");

            migrationBuilder.DropTable(
                name: "ProjectStatus");

            migrationBuilder.DropTable(
                name: "ProjectTeamCategory");

            migrationBuilder.DropTable(
                name: "ProjectZoningPlan");

            migrationBuilder.DropTable(
                name: "ServiceAreas");

            migrationBuilder.DropTable(
                name: "Shortcuts");

            migrationBuilder.DropTable(
                name: "ZoningPlanModificationStatus");

            migrationBuilder.DropTable(
                name: "ZoningPlanStatus");
        }
    }
}
