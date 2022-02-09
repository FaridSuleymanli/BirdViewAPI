using Microsoft.EntityFrameworkCore.Migrations;

namespace BirdViewAPI.Migrations
{
    public partial class CreatedVisaServiceBlogTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VisaServiceBlogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EligibilityButton = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EligibilityLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EligibilityTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SearchTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntroductionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisaTypeId = table.Column<int>(type: "int", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    ConsultationTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisaServiceBlogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VisaServiceBlogs_ConsultationTypes_ConsultationTypeId",
                        column: x => x.ConsultationTypeId,
                        principalTable: "ConsultationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VisaServiceBlogs_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VisaServiceBlogs_VisaTypes_VisaTypeId",
                        column: x => x.VisaTypeId,
                        principalTable: "VisaTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VisaServiceBlogs_ConsultationTypeId",
                table: "VisaServiceBlogs",
                column: "ConsultationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VisaServiceBlogs_CountryId",
                table: "VisaServiceBlogs",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_VisaServiceBlogs_VisaTypeId",
                table: "VisaServiceBlogs",
                column: "VisaTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VisaServiceBlogs");
        }
    }
}
