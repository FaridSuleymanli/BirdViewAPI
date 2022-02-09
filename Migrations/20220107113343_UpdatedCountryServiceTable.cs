using Microsoft.EntityFrameworkCore.Migrations;

namespace BirdViewAPI.Migrations
{
    public partial class UpdatedCountryServiceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryServices_ConsultationTypes_ConsultationTypeId",
                table: "CountryServices");

            migrationBuilder.DropColumn(
                name: "ConsultationServiceId",
                table: "CountryServices");

            migrationBuilder.AlterColumn<int>(
                name: "ConsultationTypeId",
                table: "CountryServices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryServices_ConsultationTypes_ConsultationTypeId",
                table: "CountryServices",
                column: "ConsultationTypeId",
                principalTable: "ConsultationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryServices_ConsultationTypes_ConsultationTypeId",
                table: "CountryServices");

            migrationBuilder.AlterColumn<int>(
                name: "ConsultationTypeId",
                table: "CountryServices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ConsultationServiceId",
                table: "CountryServices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryServices_ConsultationTypes_ConsultationTypeId",
                table: "CountryServices",
                column: "ConsultationTypeId",
                principalTable: "ConsultationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
