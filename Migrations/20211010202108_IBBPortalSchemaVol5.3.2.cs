using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol532 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectExpropriation_PropertyStatus_PropertyStatusID",
                table: "ProjectExpropriation");

            migrationBuilder.DropIndex(
                name: "IX_ProjectExpropriation_PropertyStatusID",
                table: "ProjectExpropriation");

            migrationBuilder.DropColumn(
                name: "PropertyStatusID",
                table: "ProjectExpropriation");

            migrationBuilder.CreateTable(
                name: "RelProjectPropertyStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectExpropriationID = table.Column<int>(type: "int", nullable: true),
                    ProjectID = table.Column<int>(type: "int", nullable: true),
                    PropertyStatusID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelProjectPropertyStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelProjectPropertyStatus_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RelProjectPropertyStatus_ProjectExpropriation_ProjectExpropriationID",
                        column: x => x.ProjectExpropriationID,
                        principalTable: "ProjectExpropriation",
                        principalColumn: "ProjectExpropriationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RelProjectPropertyStatus_PropertyStatus_PropertyStatusID",
                        column: x => x.PropertyStatusID,
                        principalTable: "PropertyStatus",
                        principalColumn: "PropertyStatusID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RelProjectPropertyStatus_ProjectExpropriationID",
                table: "RelProjectPropertyStatus",
                column: "ProjectExpropriationID");

            migrationBuilder.CreateIndex(
                name: "IX_RelProjectPropertyStatus_ProjectID",
                table: "RelProjectPropertyStatus",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_RelProjectPropertyStatus_PropertyStatusID",
                table: "RelProjectPropertyStatus",
                column: "PropertyStatusID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RelProjectPropertyStatus");

            migrationBuilder.AddColumn<int>(
                name: "PropertyStatusID",
                table: "ProjectExpropriation",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectExpropriation_PropertyStatusID",
                table: "ProjectExpropriation",
                column: "PropertyStatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectExpropriation_PropertyStatus_PropertyStatusID",
                table: "ProjectExpropriation",
                column: "PropertyStatusID",
                principalTable: "PropertyStatus",
                principalColumn: "PropertyStatusID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
