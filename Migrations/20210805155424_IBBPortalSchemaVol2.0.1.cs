using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol201 : Migration
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
                name: "FK_Department_AspNetUsers_UserID",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_District_AspNetUsers_UserID",
                table: "District");

            migrationBuilder.DropForeignKey(
                name: "FK_FileCategory_AspNetUsers_UserID",
                table: "FileCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTitle_AspNetUsers_UserID",
                table: "JobTitle");

            migrationBuilder.DropForeignKey(
                name: "FK_Management_AspNetUsers_UserID",
                table: "Management");

            migrationBuilder.DropForeignKey(
                name: "FK_Phase_AspNetUsers_UserID",
                table: "Phase");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectPhaseStatus_AspNetUsers_UserID",
                table: "ProjectPhaseStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectStatus_AspNetUsers_UserID",
                table: "ProjectStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTeamCategory_AspNetUsers_UserID",
                table: "ProjectTeamCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceArea_AspNetUsers_UserID",
                table: "ServiceArea");

            migrationBuilder.DropForeignKey(
                name: "FK_Subfunction_AspNetUsers_UserID",
                table: "Subfunction");

            migrationBuilder.DropForeignKey(
                name: "FK_SubfunctionFeature_AspNetUsers_UserID",
                table: "SubfunctionFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_ZoningPlanStatus_AspNetUsers_UserID",
                table: "ZoningPlanStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

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
                name: "AspNetUsers",
                newName: "ApplicationUser");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserToken",
                table: "ApplicationUserToken",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUser",
                table: "ApplicationUser",
                column: "Id");

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
                name: "FK_Department_ApplicationUser_UserID",
                table: "Department",
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
                name: "FK_FileCategory_ApplicationUser_UserID",
                table: "FileCategory",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Management_ApplicationUser_UserID",
                table: "Management",
                column: "UserID",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Phase_ApplicationUser_UserID",
                table: "Phase",
                column: "UserID",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectPhaseStatus_ApplicationUser_UserID",
                table: "ProjectPhaseStatus",
                column: "UserID",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectStatus_ApplicationUser_UserID",
                table: "ProjectStatus",
                column: "UserID",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTeamCategory_ApplicationUser_UserID",
                table: "ProjectTeamCategory",
                column: "UserID",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceArea_ApplicationUser_UserID",
                table: "ServiceArea",
                column: "UserID",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subfunction_ApplicationUser_UserID",
                table: "Subfunction",
                column: "UserID",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubfunctionFeature_ApplicationUser_UserID",
                table: "SubfunctionFeature",
                column: "UserID",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ZoningPlanStatus_ApplicationUser_UserID",
                table: "ZoningPlanStatus",
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
                name: "FK_Department_ApplicationUser_UserID",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_District_ApplicationUser_UserID",
                table: "District");

            migrationBuilder.DropForeignKey(
                name: "FK_FileCategory_ApplicationUser_UserID",
                table: "FileCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTitle_ApplicationUser_UserID",
                table: "JobTitle");

            migrationBuilder.DropForeignKey(
                name: "FK_Management_ApplicationUser_UserID",
                table: "Management");

            migrationBuilder.DropForeignKey(
                name: "FK_Phase_ApplicationUser_UserID",
                table: "Phase");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectPhaseStatus_ApplicationUser_UserID",
                table: "ProjectPhaseStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectStatus_ApplicationUser_UserID",
                table: "ProjectStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTeamCategory_ApplicationUser_UserID",
                table: "ProjectTeamCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceArea_ApplicationUser_UserID",
                table: "ServiceArea");

            migrationBuilder.DropForeignKey(
                name: "FK_Subfunction_ApplicationUser_UserID",
                table: "Subfunction");

            migrationBuilder.DropForeignKey(
                name: "FK_SubfunctionFeature_ApplicationUser_UserID",
                table: "SubfunctionFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_ZoningPlanStatus_ApplicationUser_UserID",
                table: "ZoningPlanStatus");

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
                name: "PK_ApplicationUser",
                table: "ApplicationUser");

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
                name: "ApplicationUser",
                newName: "AspNetUsers");

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
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

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
                name: "FK_Department_AspNetUsers_UserID",
                table: "Department",
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
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FileCategory_AspNetUsers_UserID",
                table: "FileCategory",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTitle_AspNetUsers_UserID",
                table: "JobTitle",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Management_AspNetUsers_UserID",
                table: "Management",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Phase_AspNetUsers_UserID",
                table: "Phase",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectPhaseStatus_AspNetUsers_UserID",
                table: "ProjectPhaseStatus",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectStatus_AspNetUsers_UserID",
                table: "ProjectStatus",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTeamCategory_AspNetUsers_UserID",
                table: "ProjectTeamCategory",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceArea_AspNetUsers_UserID",
                table: "ServiceArea",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subfunction_AspNetUsers_UserID",
                table: "Subfunction",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubfunctionFeature_AspNetUsers_UserID",
                table: "SubfunctionFeature",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ZoningPlanStatus_AspNetUsers_UserID",
                table: "ZoningPlanStatus",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
