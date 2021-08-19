using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol341 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectPermissionProvider",
                table: "ProjectPermission");

            migrationBuilder.AddColumn<int>(
                name: "OrganizationID",
                table: "ProjectPermission",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "ProjectPermission",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PropertyStatusDescription",
                table: "ProjectExpropriation",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropertyStatusID",
                table: "ProjectExpropriation",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TransactionTypes",
                columns: table => new
                {
                    TransactionTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionTypeName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    TransactionTypeDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionTypes", x => x.TransactionTypeID);
                    table.ForeignKey(
                        name: "FK_TransactionTypes_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
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
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionMessages", x => x.TransactionMessageID);
                    table.ForeignKey(
                        name: "FK_TransactionMessages_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransactionMessages_TransactionTypes_TransactionTypeID",
                        column: x => x.TransactionTypeID,
                        principalTable: "TransactionTypes",
                        principalColumn: "TransactionTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPermission_OrganizationID",
                table: "ProjectPermission",
                column: "OrganizationID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPermission_UserID",
                table: "ProjectPermission",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectExpropriation_PropertyStatusID",
                table: "ProjectExpropriation",
                column: "PropertyStatusID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectExpropriation_PropertyStatus_PropertyStatusID",
                table: "ProjectExpropriation",
                column: "PropertyStatusID",
                principalTable: "PropertyStatus",
                principalColumn: "PropertyStatusID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectPermission_AspNetUsers_UserID",
                table: "ProjectPermission",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectPermission_Organization_OrganizationID",
                table: "ProjectPermission",
                column: "OrganizationID",
                principalTable: "Organization",
                principalColumn: "OrganizationID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectExpropriation_PropertyStatus_PropertyStatusID",
                table: "ProjectExpropriation");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectPermission_AspNetUsers_UserID",
                table: "ProjectPermission");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectPermission_Organization_OrganizationID",
                table: "ProjectPermission");

            migrationBuilder.DropTable(
                name: "TransactionMessages");

            migrationBuilder.DropTable(
                name: "TransactionTypes");

            migrationBuilder.DropIndex(
                name: "IX_ProjectPermission_OrganizationID",
                table: "ProjectPermission");

            migrationBuilder.DropIndex(
                name: "IX_ProjectPermission_UserID",
                table: "ProjectPermission");

            migrationBuilder.DropIndex(
                name: "IX_ProjectExpropriation_PropertyStatusID",
                table: "ProjectExpropriation");

            migrationBuilder.DropColumn(
                name: "OrganizationID",
                table: "ProjectPermission");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "ProjectPermission");

            migrationBuilder.DropColumn(
                name: "PropertyStatusDescription",
                table: "ProjectExpropriation");

            migrationBuilder.DropColumn(
                name: "PropertyStatusID",
                table: "ProjectExpropriation");

            migrationBuilder.AddColumn<string>(
                name: "ProjectPermissionProvider",
                table: "ProjectPermission",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);
        }
    }
}
