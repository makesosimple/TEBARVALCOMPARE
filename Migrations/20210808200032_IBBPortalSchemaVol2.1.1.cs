using Microsoft.EntityFrameworkCore.Migrations;

namespace IBBPortal.Migrations
{
    public partial class IBBPortalSchemaVol211 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DistrictID",
                table: "Contractor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CityID",
                table: "Contractor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ContractorTypeID",
                table: "Contractor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contractor_ContractorTypeID",
                table: "Contractor",
                column: "ContractorTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contractor_City_CityID",
                table: "Contractor",
                column: "CityID",
                principalTable: "City",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contractor_ContractorType_ContractorTypeID",
                table: "Contractor",
                column: "ContractorTypeID",
                principalTable: "ContractorType",
                principalColumn: "ContractorTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contractor_District_DistrictID",
                table: "Contractor",
                column: "DistrictID",
                principalTable: "District",
                principalColumn: "DistrictID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contractor_City_CityID",
                table: "Contractor");

            migrationBuilder.DropForeignKey(
                name: "FK_Contractor_ContractorType_ContractorTypeID",
                table: "Contractor");

            migrationBuilder.DropForeignKey(
                name: "FK_Contractor_District_DistrictID",
                table: "Contractor");

            migrationBuilder.DropIndex(
                name: "IX_Contractor_ContractorTypeID",
                table: "Contractor");

            migrationBuilder.DropColumn(
                name: "ContractorTypeID",
                table: "Contractor");

            migrationBuilder.AlterColumn<int>(
                name: "DistrictID",
                table: "Contractor",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CityID",
                table: "Contractor",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
