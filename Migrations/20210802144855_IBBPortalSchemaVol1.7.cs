using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_FileCategory_ParentFileCategoryID",
                table: "FileCategory",
                column: "ParentFileCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_FileCategory_UserID",
                table: "FileCategory",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileCategory");
        }
    }
}
