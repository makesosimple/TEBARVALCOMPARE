using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Board_AspNetUsers_UserID",
                table: "Board");

            migrationBuilder.DropForeignKey(
                name: "FK_City_AspNetUsers_UserID",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_Contractor_AspNetUsers_UserID",
                table: "Contractor");

            migrationBuilder.DropForeignKey(
                name: "FK_District_AspNetUsers_UserID",
                table: "District");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTitle_AspNetUsers_UserID",
                table: "JobTitle");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "ApplicationUserToken");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "ApplicationUserRole");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "ApplicationUserLogin");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "ApplicationUserClaim");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "ApplicationRole");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "ApplicationRoleClaim");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "ApplicationUserRole",
                newName: "IX_ApplicationUserRole_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "ApplicationUserLogin",
                newName: "IX_ApplicationUserLogin_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "ApplicationUserClaim",
                newName: "IX_ApplicationUserClaim_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "ApplicationRoleClaim",
                newName: "IX_ApplicationRoleClaim_RoleId");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "District",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserToken",
                table: "ApplicationUserToken",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserRole",
                table: "ApplicationUserRole",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserLogin",
                table: "ApplicationUserLogin",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserClaim",
                table: "ApplicationUserClaim",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationRole",
                table: "ApplicationRole",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationRoleClaim",
                table: "ApplicationRoleClaim",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);
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
                        name: "FK_Department_ApplicationUser_UserID",
                        column: x => x.UserID,
                        principalTable: "ApplicationUser",
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
                        name: "FK_FileCategory_ApplicationUser_UserID",
                        column: x => x.UserID,
                        principalTable: "ApplicationUser",
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
                        name: "FK_Management_ApplicationUser_UserID",
                        column: x => x.UserID,
                        principalTable: "ApplicationUser",
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
                        name: "FK_Phase_ApplicationUser_UserID",
                        column: x => x.UserID,
                        principalTable: "ApplicationUser",
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
                        name: "FK_ProjectPhaseStatus_ApplicationUser_UserID",
                        column: x => x.UserID,
                        principalTable: "ApplicationUser",
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
                        name: "FK_ProjectStatus_ApplicationUser_UserID",
                        column: x => x.UserID,
                        principalTable: "ApplicationUser",
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
                        name: "FK_ProjectTeamCategory_ApplicationUser_UserID",
                        column: x => x.UserID,
                        principalTable: "ApplicationUser",
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
                        name: "FK_ServiceArea_ApplicationUser_UserID",
                        column: x => x.UserID,
                        principalTable: "ApplicationUser",
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
                        name: "FK_Subfunction_ApplicationUser_UserID",
                        column: x => x.UserID,
                        principalTable: "ApplicationUser",
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
                        name: "FK_ZoningPlanStatus_ApplicationUser_UserID",
                        column: x => x.UserID,
                        principalTable: "ApplicationUser",
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
                        name: "FK_SubfunctionFeature_ApplicationUser_UserID",
                        column: x => x.UserID,
                        principalTable: "ApplicationUser",
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
                name: "EmailIndex",
                table: "ApplicationUser",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "ApplicationUser",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "FK_ApplicationRoleClaim_ApplicationRole_RoleId",
                table: "ApplicationRoleClaim",
                column: "RoleId",
                principalTable: "ApplicationRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserClaim_ApplicationUser_UserId",
                table: "ApplicationUserClaim",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserLogin_ApplicationUser_UserId",
                table: "ApplicationUserLogin",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserRole_ApplicationRole_RoleId",
                table: "ApplicationUserRole",
                column: "RoleId",
                principalTable: "ApplicationRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserRole_ApplicationUser_UserId",
                table: "ApplicationUserRole",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserToken_ApplicationUser_UserId",
                table: "ApplicationUserToken",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Board_ApplicationUser_UserID",
                table: "Board",
                column: "UserID",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_City_ApplicationUser_UserID",
                table: "City",
                column: "UserID",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contractor_ApplicationUser_UserID",
                table: "Contractor",
                column: "UserID",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_District_ApplicationUser_UserID",
                table: "District",
                column: "UserID",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTitle_ApplicationUser_UserID",
                table: "JobTitle",
                column: "UserID",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationRoleClaim_ApplicationRole_RoleId",
                table: "ApplicationRoleClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserClaim_ApplicationUser_UserId",
                table: "ApplicationUserClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserLogin_ApplicationUser_UserId",
                table: "ApplicationUserLogin");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserRole_ApplicationRole_RoleId",
                table: "ApplicationUserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserRole_ApplicationUser_UserId",
                table: "ApplicationUserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserToken_ApplicationUser_UserId",
                table: "ApplicationUserToken");

            migrationBuilder.DropForeignKey(
                name: "FK_Board_ApplicationUser_UserID",
                table: "Board");

            migrationBuilder.DropForeignKey(
                name: "FK_City_ApplicationUser_UserID",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_Contractor_ApplicationUser_UserID",
                table: "Contractor");

            migrationBuilder.DropForeignKey(
                name: "FK_District_ApplicationUser_UserID",
                table: "District");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTitle_ApplicationUser_UserID",
                table: "JobTitle");

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

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserToken",
                table: "ApplicationUserToken");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserRole",
                table: "ApplicationUserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserLogin",
                table: "ApplicationUserLogin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserClaim",
                table: "ApplicationUserClaim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationRoleClaim",
                table: "ApplicationRoleClaim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationRole",
                table: "ApplicationRole");

            migrationBuilder.RenameTable(
                name: "ApplicationUserToken",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "ApplicationUserRole",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "ApplicationUserLogin",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "ApplicationUserClaim",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "ApplicationRoleClaim",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "ApplicationRole",
                newName: "AspNetRoles");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUserRole_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUserLogin_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUserClaim_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationRoleClaim_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "District",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Board_AspNetUsers_UserID",
                table: "Board",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_City_AspNetUsers_UserID",
                table: "City",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contractor_AspNetUsers_UserID",
                table: "Contractor",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_District_AspNetUsers_UserID",
                table: "District",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTitle_AspNetUsers_UserID",
                table: "JobTitle",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
