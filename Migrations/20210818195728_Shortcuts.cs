using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class Shortcuts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Shortcuts");
        }
    }
}
