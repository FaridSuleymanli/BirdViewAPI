using Microsoft.EntityFrameworkCore.Migrations;

namespace BirdViewAPI.Migrations
{
    public partial class ChangedVisaAndCountryRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_VisaTypes_VisaTypeId",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Countries_VisaTypeId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "VisaTypeId",
                table: "Countries");

            migrationBuilder.CreateTable(
                name: "VisaCountries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisaTypeId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisaCountries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VisaCountries_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisaCountries_VisaTypes_VisaTypeId",
                        column: x => x.VisaTypeId,
                        principalTable: "VisaTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VisaCountries_CountryId",
                table: "VisaCountries",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_VisaCountries_VisaTypeId",
                table: "VisaCountries",
                column: "VisaTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VisaCountries");

            migrationBuilder.AddColumn<int>(
                name: "VisaTypeId",
                table: "Countries",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Countries_VisaTypeId",
                table: "Countries",
                column: "VisaTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_VisaTypes_VisaTypeId",
                table: "Countries",
                column: "VisaTypeId",
                principalTable: "VisaTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
