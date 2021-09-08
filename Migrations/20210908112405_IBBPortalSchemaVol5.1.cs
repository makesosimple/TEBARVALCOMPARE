using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol51 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TransactionLog",
                columns: table => new
                {
                    TransactionLogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionMessageID = table.Column<int>(type: "int", nullable: false),
                    TransactionTypeID = table.Column<int>(type: "int", nullable: true),
                    ProjectID = table.Column<int>(type: "int", nullable: true),
                    TransactionLogMessageContent = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    TransactionLogRead = table.Column<bool>(type: "bit", nullable: false),
                    TransactionLogForUserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TransactionLogSlug = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionLog", x => x.TransactionLogID);
                    table.ForeignKey(
                        name: "FK_TransactionLog_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransactionLog_TransactionMessages_TransactionMessageID",
                        column: x => x.TransactionMessageID,
                        principalTable: "TransactionMessages",
                        principalColumn: "TransactionMessageID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionLog_TransactionTypes_TransactionTypeID",
                        column: x => x.TransactionTypeID,
                        principalTable: "TransactionTypes",
                        principalColumn: "TransactionTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransactionLog_User_TransactionLogForUserID",
                        column: x => x.TransactionLogForUserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLog_ProjectID",
                table: "TransactionLog",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLog_TransactionLogForUserID",
                table: "TransactionLog",
                column: "TransactionLogForUserID");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLog_TransactionMessageID",
                table: "TransactionLog",
                column: "TransactionMessageID");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLog_TransactionTypeID",
                table: "TransactionLog",
                column: "TransactionTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransactionLog");
        }
    }
}
