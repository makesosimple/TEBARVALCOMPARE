using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol505 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProjectPaftaAdaParsel",
                table: "ProjectField",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RequestingAuthorityID",
                table: "Project",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Project_RequestingAuthorityID",
                table: "Project",
                column: "RequestingAuthorityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Authority_RequestingAuthorityID",
                table: "Project",
                column: "RequestingAuthorityID",
                principalTable: "Authority",
                principalColumn: "AuthorityID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Authority_RequestingAuthorityID",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Project_RequestingAuthorityID",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "RequestingAuthorityID",
                table: "Project");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectPaftaAdaParsel",
                table: "ProjectField",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);
        }
    }
}
