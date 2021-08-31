using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DashboardSummaryModel",
                columns: table => new
                {
                    NumberOfProjects = table.Column<int>(type: "int", nullable: false),
                    ProjectsStartedInLastMonth = table.Column<int>(type: "int", nullable: false),
                    NumberOfCompletedProjects = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ServicePieChartModel",
                columns: table => new
                {
                    ServiceAreaID = table.Column<int>(type: "int", nullable: false),
                    ServiceAreaTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfProjects = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ShortcutListModel",
                columns: table => new
                {
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    ProjectTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
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
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shortcuts", x => x.ShortcutsID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProfilePicture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Authority",
                columns: table => new
                {
                    AuthorityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorityTitle = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    AuthorityDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authority", x => x.AuthorityID);
                    table.ForeignKey(
                        name: "FK_Authority_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Board",
                columns: table => new
                {
                    BoardID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoardTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BoardDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Board", x => x.BoardID);
                    table.ForeignKey(
                        name: "FK_Board_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityCode = table.Column<int>(type: "int", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityID);
                    table.ForeignKey(
                        name: "FK_City_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContractorType",
                columns: table => new
                {
                    ContractorTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractorTypeTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ContractorTypeDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractorType", x => x.ContractorTypeID);
                    table.ForeignKey(
                        name: "FK_ContractorType_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                        name: "FK_Department_Department_ParentDepartmentID",
                        column: x => x.ParentDepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Department_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExpropriationStatus",
                columns: table => new
                {
                    ExpropriationStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpropriationStatusTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ExpropriationStatusDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpropriationStatus", x => x.ExpropriationStatusID);
                    table.ForeignKey(
                        name: "FK_ExpropriationStatus_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
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
                        name: "FK_FileCategory_FileCategory_ParentFileCategoryID",
                        column: x => x.ParentFileCategoryID,
                        principalTable: "FileCategory",
                        principalColumn: "FileCategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FileCategory_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobField",
                columns: table => new
                {
                    JobFieldID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobFieldTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    JobFieldDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobField", x => x.JobFieldID);
                    table.ForeignKey(
                        name: "FK_JobField_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobTitle",
                columns: table => new
                {
                    JobTitleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    JobDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitle", x => x.JobTitleID);
                    table.ForeignKey(
                        name: "FK_JobTitle_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    OrganizationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationTitle = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    OrganizationDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.OrganizationID);
                    table.ForeignKey(
                        name: "FK_Organization_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
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
                    PhaseOrder = table.Column<int>(type: "int", nullable: false),
                    PhaseDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PreviousPhaseID = table.Column<int>(type: "int", nullable: true),
                    isPresentation = table.Column<bool>(type: "bit", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phase", x => x.PhaseID);
                    table.ForeignKey(
                        name: "FK_Phase_Phase_PreviousPhaseID",
                        column: x => x.PreviousPhaseID,
                        principalTable: "Phase",
                        principalColumn: "PhaseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Phase_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectImportance",
                columns: table => new
                {
                    ProjectImportanceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectImportanceTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProjectImportanceDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectImportance", x => x.ProjectImportanceID);
                    table.ForeignKey(
                        name: "FK_ProjectImportance_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
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
                        name: "FK_ProjectPhaseStatus_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
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
                        name: "FK_ProjectStatus_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
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
                        name: "FK_ProjectTeamCategory_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PropertyStatus",
                columns: table => new
                {
                    PropertyStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyStatusTitle = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    PropertyStatusDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyStatus", x => x.PropertyStatusID);
                    table.ForeignKey(
                        name: "FK_PropertyStatus_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RelationType",
                columns: table => new
                {
                    RelationTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelationTypeTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RelationTypeDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationType", x => x.RelationTypeID);
                    table.ForeignKey(
                        name: "FK_RelationType_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Role_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
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
                        name: "FK_ServiceArea_ServiceArea_ParentServiceAreaID",
                        column: x => x.ParentServiceAreaID,
                        principalTable: "ServiceArea",
                        principalColumn: "ServiceAreaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceArea_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
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
                        name: "FK_Subfunction_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransactionTypes",
                columns: table => new
                {
                    TransactionTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionTypeName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    TransactionTypeDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    TransactionTypeSlug = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionTypes", x => x.TransactionTypeID);
                    table.ForeignKey(
                        name: "FK_TransactionTypes_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZoningPlanModificationStatus",
                columns: table => new
                {
                    ZoningPlanModificationStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZoningPlanModificationStatusTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ZoningPlanModificationStatusDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZoningPlanModificationStatus", x => x.ZoningPlanModificationStatusID);
                    table.ForeignKey(
                        name: "FK_ZoningPlanModificationStatus_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
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
                    ZoningPlanStatusDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZoningPlanStatus", x => x.ZoningPlanStatusID);
                    table.ForeignKey(
                        name: "FK_ZoningPlanStatus_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    DistrictID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictCode = table.Column<int>(type: "int", nullable: false),
                    DistrictName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.DistrictID);
                    table.ForeignKey(
                        name: "FK_District_City_CityID",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_District_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_SubfunctionFeature_Subfunction_SubfunctionID",
                        column: x => x.SubfunctionID,
                        principalTable: "Subfunction",
                        principalColumn: "SubfunctionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubfunctionFeature_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransactionMessages",
                columns: table => new
                {
                    TransactionMessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionTypeID = table.Column<int>(type: "int", nullable: true),
                    TransactionMessageContent = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    TransactionMessageDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TransactionMessageSlug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionMessages", x => x.TransactionMessageID);
                    table.ForeignKey(
                        name: "FK_TransactionMessages_TransactionTypes_TransactionTypeID",
                        column: x => x.TransactionTypeID,
                        principalTable: "TransactionTypes",
                        principalColumn: "TransactionTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransactionMessages_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contractor",
                columns: table => new
                {
                    ContractorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    TaxCode = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    TaxOffice = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    CityID = table.Column<int>(type: "int", nullable: true),
                    DistrictID = table.Column<int>(type: "int", nullable: true),
                    ContractorTypeID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Website = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contractor", x => x.ContractorID);
                    table.ForeignKey(
                        name: "FK_Contractor_City_CityID",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contractor_ContractorType_ContractorTypeID",
                        column: x => x.ContractorTypeID,
                        principalTable: "ContractorType",
                        principalColumn: "ContractorTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contractor_District_DistrictID",
                        column: x => x.DistrictID,
                        principalTable: "District",
                        principalColumn: "DistrictID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contractor_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PersonSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PersonPhone = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true),
                    PersonEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    isInternal = table.Column<bool>(type: "bit", nullable: false),
                    JobTitleID = table.Column<int>(type: "int", nullable: true),
                    DepartmentID = table.Column<int>(type: "int", nullable: true),
                    ContractorID = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonID);
                    table.ForeignKey(
                        name: "FK_Person_Contractor_ContractorID",
                        column: x => x.ContractorID,
                        principalTable: "Contractor",
                        principalColumn: "ContractorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_JobTitle_JobTitleID",
                        column: x => x.JobTitleID,
                        principalTable: "JobTitle",
                        principalColumn: "JobTitleID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ProjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTitle = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ProjectCode = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    ProjectIBBCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestingDepartmentID = table.Column<int>(type: "int", nullable: true),
                    ResponsibleDepartmentID = table.Column<int>(type: "int", nullable: true),
                    ProjectOwnerPersonID = table.Column<int>(type: "int", nullable: true),
                    ProjectServiceAreaID = table.Column<int>(type: "int", nullable: true),
                    ProjectImportanceID = table.Column<int>(type: "int", nullable: true),
                    ProjectStatusID = table.Column<int>(type: "int", nullable: true),
                    ProjectStatusDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ProjectStatusDescriptionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstimatedProjectCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ProjectID);
                    table.ForeignKey(
                        name: "FK_Project_Department_RequestingDepartmentID",
                        column: x => x.RequestingDepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_Department_ResponsibleDepartmentID",
                        column: x => x.ResponsibleDepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_Person_ProjectOwnerPersonID",
                        column: x => x.ProjectOwnerPersonID,
                        principalTable: "Person",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_ProjectImportance_ProjectImportanceID",
                        column: x => x.ProjectImportanceID,
                        principalTable: "ProjectImportance",
                        principalColumn: "ProjectImportanceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_ProjectStatus_ProjectStatusID",
                        column: x => x.ProjectStatusID,
                        principalTable: "ProjectStatus",
                        principalColumn: "ProjectStatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_ServiceArea_ProjectServiceAreaID",
                        column: x => x.ProjectServiceAreaID,
                        principalTable: "ServiceArea",
                        principalColumn: "ServiceAreaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                    table.ForeignKey(
                        name: "FK_ProjectBoardApproval_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectExpropriation",
                columns: table => new
                {
                    ProjectExpropriationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: true),
                    PropertyStatusID = table.Column<int>(type: "int", nullable: true),
                    PropertyStatusDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ExpropriationStatusID = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_ProjectExpropriation_ExpropriationStatus_ExpropriationStatusID",
                        column: x => x.ExpropriationStatusID,
                        principalTable: "ExpropriationStatus",
                        principalColumn: "ExpropriationStatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectExpropriation_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectExpropriation_PropertyStatus_PropertyStatusID",
                        column: x => x.PropertyStatusID,
                        principalTable: "PropertyStatus",
                        principalColumn: "PropertyStatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectExpropriation_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                    table.ForeignKey(
                        name: "FK_ProjectFeasibility_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectField",
                columns: table => new
                {
                    ProjectFieldID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: true),
                    IsProjectInIstanbul = table.Column<bool>(type: "bit", nullable: false),
                    DistrictID = table.Column<int>(type: "int", nullable: true),
                    ProjectAddress = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ProjectCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProjectArea = table.Column<double>(type: "float", nullable: true),
                    ProjectConstructionArea = table.Column<double>(type: "float", nullable: true),
                    ProjectPaysageArea = table.Column<double>(type: "float", nullable: true),
                    ProjectPaftaAdaParsel = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    KML = table.Column<string>(type: "varchar(MAX)", nullable: true),
                    ProjectLongitude = table.Column<decimal>(type: "decimal(9,6)", nullable: true),
                    ProjectLatitude = table.Column<decimal>(type: "decimal(9,6)", nullable: true),
                    ProjectPoint = table.Column<Point>(type: "geography", nullable: true),
                    ProjectLineString = table.Column<LineString>(type: "geography", nullable: true),
                    ProjectPolygon = table.Column<Polygon>(type: "geography", nullable: true),
                    coordinates = table.Column<string>(type: "nvarchar(max)", maxLength: 16000, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectField", x => x.ProjectFieldID);
                    table.ForeignKey(
                        name: "FK_ProjectField_District_DistrictID",
                        column: x => x.DistrictID,
                        principalTable: "District",
                        principalColumn: "DistrictID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectField_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectField_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectPermission",
                columns: table => new
                {
                    ProjectPermissionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: true),
                    OrganizationID = table.Column<int>(type: "int", nullable: true),
                    IsPermissionNeeded = table.Column<bool>(type: "bit", nullable: false),
                    ProjectPermissionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProjectPermissionReason = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectPermission", x => x.ProjectPermissionID);
                    table.ForeignKey(
                        name: "FK_ProjectPermission_Organization_OrganizationID",
                        column: x => x.OrganizationID,
                        principalTable: "Organization",
                        principalColumn: "OrganizationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectPermission_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectPermission_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                    table.ForeignKey(
                        name: "FK_ProjectPerson_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                    table.ForeignKey(
                        name: "FK_ProjectPhase_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectRelation",
                columns: table => new
                {
                    ProjectRelationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: true),
                    RelatedProjectID = table.Column<int>(type: "int", nullable: true),
                    RelationTypeID = table.Column<int>(type: "int", nullable: true),
                    ProjectRelationDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectRelation", x => x.ProjectRelationID);
                    table.ForeignKey(
                        name: "FK_ProjectRelation_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectRelation_Project_RelatedProjectID",
                        column: x => x.RelatedProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectRelation_RelationType_RelationTypeID",
                        column: x => x.RelationTypeID,
                        principalTable: "RelationType",
                        principalColumn: "RelationTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectRelation_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectSubfunctionFeature",
                columns: table => new
                {
                    ProjectSubfunctionFeatureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: true),
                    SubfunctionID = table.Column<int>(type: "int", nullable: true),
                    SubfunctionFeatureID = table.Column<int>(type: "int", nullable: true),
                    SubfunctionFeatureValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubfunctionFeatureValueDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectSubfunctionFeature", x => x.ProjectSubfunctionFeatureID);
                    table.ForeignKey(
                        name: "FK_ProjectSubfunctionFeature_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectSubfunctionFeature_Subfunction_SubfunctionID",
                        column: x => x.SubfunctionID,
                        principalTable: "Subfunction",
                        principalColumn: "SubfunctionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectSubfunctionFeature_SubfunctionFeature_SubfunctionFeatureID",
                        column: x => x.SubfunctionFeatureID,
                        principalTable: "SubfunctionFeature",
                        principalColumn: "SubfunctionFeatureID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectSubfunctionFeature_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
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
                        name: "FK_ProjectZoningPlan_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
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
                    table.ForeignKey(
                        name: "FK_ProjectBidding_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Authority_UserID",
                table: "Authority",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Board_UserID",
                table: "Board",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_City_CityCode",
                table: "City",
                column: "CityCode");

            migrationBuilder.CreateIndex(
                name: "IX_City_UserID",
                table: "City",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Contractor_CityID",
                table: "Contractor",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Contractor_ContractorTypeID",
                table: "Contractor",
                column: "ContractorTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Contractor_DistrictID",
                table: "Contractor",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_Contractor_UserID",
                table: "Contractor",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorType_UserID",
                table: "ContractorType",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Department_ParentDepartmentID",
                table: "Department",
                column: "ParentDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Department_UserID",
                table: "Department",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_District_CityID",
                table: "District",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_District_UserID",
                table: "District",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ExpropriationStatus_UserID",
                table: "ExpropriationStatus",
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
                name: "IX_JobField_UserID",
                table: "JobField",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitle_UserID",
                table: "JobTitle",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_UserID",
                table: "Organization",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Person_ContractorID",
                table: "Person",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_Person_DepartmentID",
                table: "Person",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Person_JobTitleID",
                table: "Person",
                column: "JobTitleID");

            migrationBuilder.CreateIndex(
                name: "IX_Person_UserID",
                table: "Person",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Phase_PreviousPhaseID",
                table: "Phase",
                column: "PreviousPhaseID");

            migrationBuilder.CreateIndex(
                name: "IX_Phase_UserID",
                table: "Phase",
                column: "UserID");

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
                name: "IX_Project_RequestingDepartmentID",
                table: "Project",
                column: "RequestingDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ResponsibleDepartmentID",
                table: "Project",
                column: "ResponsibleDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_UserID",
                table: "Project",
                column: "UserID");

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
                name: "IX_ProjectExpropriation_ExpropriationStatusID",
                table: "ProjectExpropriation",
                column: "ExpropriationStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectExpropriation_ProjectID",
                table: "ProjectExpropriation",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectExpropriation_PropertyStatusID",
                table: "ProjectExpropriation",
                column: "PropertyStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectExpropriation_UserID",
                table: "ProjectExpropriation",
                column: "UserID");

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

            migrationBuilder.CreateIndex(
                name: "IX_ProjectField_DistrictID",
                table: "ProjectField",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectField_ProjectID",
                table: "ProjectField",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectField_UserID",
                table: "ProjectField",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectImportance_UserID",
                table: "ProjectImportance",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPermission_OrganizationID",
                table: "ProjectPermission",
                column: "OrganizationID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPermission_ProjectID",
                table: "ProjectPermission",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPermission_UserID",
                table: "ProjectPermission",
                column: "UserID");

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

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPhaseStatus_UserID",
                table: "ProjectPhaseStatus",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectRelation_ProjectID",
                table: "ProjectRelation",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectRelation_RelatedProjectID",
                table: "ProjectRelation",
                column: "RelatedProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectRelation_RelationTypeID",
                table: "ProjectRelation",
                column: "RelationTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectRelation_UserID",
                table: "ProjectRelation",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectStatus_UserID",
                table: "ProjectStatus",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSubfunctionFeature_ProjectID",
                table: "ProjectSubfunctionFeature",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSubfunctionFeature_SubfunctionFeatureID",
                table: "ProjectSubfunctionFeature",
                column: "SubfunctionFeatureID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSubfunctionFeature_SubfunctionID",
                table: "ProjectSubfunctionFeature",
                column: "SubfunctionID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSubfunctionFeature_UserID",
                table: "ProjectSubfunctionFeature",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTeamCategory_UserID",
                table: "ProjectTeamCategory",
                column: "UserID");

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

            migrationBuilder.CreateIndex(
                name: "IX_PropertyStatus_UserID",
                table: "PropertyStatus",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_RelationType_UserID",
                table: "RelationType",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Role_UserID",
                table: "Role",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Role",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceArea_ParentServiceAreaID",
                table: "ServiceArea",
                column: "ParentServiceAreaID");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceArea_UserID",
                table: "ServiceArea",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Shortcuts_ShortcutsProjectID",
                table: "Shortcuts",
                column: "ShortcutsProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Shortcuts_ShortcutsUserID",
                table: "Shortcuts",
                column: "ShortcutsUserID");

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
                name: "IX_TransactionMessages_TransactionTypeID",
                table: "TransactionMessages",
                column: "TransactionTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionMessages_UserID",
                table: "TransactionMessages",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionTypes_UserID",
                table: "TransactionTypes",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserID",
                table: "User",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "User",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ZoningPlanModificationStatus_UserID",
                table: "ZoningPlanModificationStatus",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ZoningPlanStatus_UserID",
                table: "ZoningPlanStatus",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authority");

            migrationBuilder.DropTable(
                name: "DashboardSummaryModel");

            migrationBuilder.DropTable(
                name: "FileCategory");

            migrationBuilder.DropTable(
                name: "ProjectBidding");

            migrationBuilder.DropTable(
                name: "ProjectBoardApproval");

            migrationBuilder.DropTable(
                name: "ProjectExpropriation");

            migrationBuilder.DropTable(
                name: "ProjectFeasibility");

            migrationBuilder.DropTable(
                name: "ProjectField");

            migrationBuilder.DropTable(
                name: "ProjectPermission");

            migrationBuilder.DropTable(
                name: "ProjectPerson");

            migrationBuilder.DropTable(
                name: "ProjectRelation");

            migrationBuilder.DropTable(
                name: "ProjectSubfunctionFeature");

            migrationBuilder.DropTable(
                name: "ProjectTeamCategory");

            migrationBuilder.DropTable(
                name: "ProjectZoningPlan");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "ServicePieChartModel");

            migrationBuilder.DropTable(
                name: "ShortcutListModel");

            migrationBuilder.DropTable(
                name: "Shortcuts");

            migrationBuilder.DropTable(
                name: "TransactionMessages");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "ProjectPhase");

            migrationBuilder.DropTable(
                name: "Board");

            migrationBuilder.DropTable(
                name: "ExpropriationStatus");

            migrationBuilder.DropTable(
                name: "PropertyStatus");

            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.DropTable(
                name: "JobField");

            migrationBuilder.DropTable(
                name: "RelationType");

            migrationBuilder.DropTable(
                name: "SubfunctionFeature");

            migrationBuilder.DropTable(
                name: "ZoningPlanModificationStatus");

            migrationBuilder.DropTable(
                name: "ZoningPlanStatus");

            migrationBuilder.DropTable(
                name: "TransactionTypes");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Phase");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "ProjectPhaseStatus");

            migrationBuilder.DropTable(
                name: "Subfunction");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "ProjectImportance");

            migrationBuilder.DropTable(
                name: "ProjectStatus");

            migrationBuilder.DropTable(
                name: "ServiceArea");

            migrationBuilder.DropTable(
                name: "Contractor");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "JobTitle");

            migrationBuilder.DropTable(
                name: "ContractorType");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
