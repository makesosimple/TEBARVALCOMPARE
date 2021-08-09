using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol241 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Phase_PreviousPhaseID",
                table: "Phase",
                column: "PreviousPhaseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Phase_Phase_PreviousPhaseID",
                table: "Phase",
                column: "PreviousPhaseID",
                principalTable: "Phase",
                principalColumn: "PhaseID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phase_Phase_PreviousPhaseID",
                table: "Phase");

            migrationBuilder.DropIndex(
                name: "IX_Phase_PreviousPhaseID",
                table: "Phase");
        }
    }
}
