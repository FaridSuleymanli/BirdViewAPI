using Microsoft.EntityFrameworkCore.Migrations;

namespace BirdViewAPI.Migrations
{
    public partial class ChangedVisaCountryDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisaCountries_Countries_CountryId",
                table: "VisaCountries");

            migrationBuilder.DropForeignKey(
                name: "FK_VisaCountries_VisaTypes_VisaTypeId",
                table: "VisaCountries");

            migrationBuilder.AlterColumn<int>(
                name: "VisaTypeId",
                table: "VisaCountries",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "VisaCountries",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_VisaCountries_Countries_CountryId",
                table: "VisaCountries",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisaCountries_VisaTypes_VisaTypeId",
                table: "VisaCountries",
                column: "VisaTypeId",
                principalTable: "VisaTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisaCountries_Countries_CountryId",
                table: "VisaCountries");

            migrationBuilder.DropForeignKey(
                name: "FK_VisaCountries_VisaTypes_VisaTypeId",
                table: "VisaCountries");

            migrationBuilder.AlterColumn<int>(
                name: "VisaTypeId",
                table: "VisaCountries",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "VisaCountries",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_VisaCountries_Countries_CountryId",
                table: "VisaCountries",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VisaCountries_VisaTypes_VisaTypeId",
                table: "VisaCountries",
                column: "VisaTypeId",
                principalTable: "VisaTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
