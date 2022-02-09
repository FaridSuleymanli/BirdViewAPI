using Microsoft.EntityFrameworkCore.Migrations;

namespace BirdViewAPI.Migrations
{
    public partial class ChangedCountryForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_VisaTypes_VisaTypeId",
                table: "Countries");

            migrationBuilder.AlterColumn<int>(
                name: "VisaTypeId",
                table: "Countries",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_VisaTypes_VisaTypeId",
                table: "Countries",
                column: "VisaTypeId",
                principalTable: "VisaTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_VisaTypes_VisaTypeId",
                table: "Countries");

            migrationBuilder.AlterColumn<int>(
                name: "VisaTypeId",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_VisaTypes_VisaTypeId",
                table: "Countries",
                column: "VisaTypeId",
                principalTable: "VisaTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
