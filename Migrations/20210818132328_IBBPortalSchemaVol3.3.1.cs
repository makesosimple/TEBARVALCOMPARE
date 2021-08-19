using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol331 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_TransactionTypes_UserID",
                table: "TransactionTypes",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransactionTypes");
        }
    }
}
