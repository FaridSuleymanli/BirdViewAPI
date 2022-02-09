using Microsoft.EntityFrameworkCore.Migrations;

namespace BirdViewAPI.Migrations
{
    public partial class ChangedConsultationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConsultationTypeId",
                table: "CountryServices",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ConsultationType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BannerTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BannerSubtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconBgColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisatypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultationType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsultationType_VisaTypes_VisatypeId",
                        column: x => x.VisatypeId,
                        principalTable: "VisaTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CountryServices_ConsultationTypeId",
                table: "CountryServices",
                column: "ConsultationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultationType_VisatypeId",
                table: "ConsultationType",
                column: "VisatypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryServices_ConsultationType_ConsultationTypeId",
                table: "CountryServices",
                column: "ConsultationTypeId",
                principalTable: "ConsultationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryServices_ConsultationType_ConsultationTypeId",
                table: "CountryServices");

            migrationBuilder.DropTable(
                name: "ConsultationType");

            migrationBuilder.DropIndex(
                name: "IX_CountryServices_ConsultationTypeId",
                table: "CountryServices");

            migrationBuilder.DropColumn(
                name: "ConsultationTypeId",
                table: "CountryServices");
        }
    }
}
