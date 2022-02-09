using Microsoft.EntityFrameworkCore.Migrations;

namespace BirdViewAPI.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IntroBanners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BannerImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisaServiceBlogId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntroBanners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IntroBanners_VisaServiceBlogs_VisaServiceBlogId",
                        column: x => x.VisaServiceBlogId,
                        principalTable: "VisaServiceBlogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IntroBanners_VisaServiceBlogId",
                table: "IntroBanners",
                column: "VisaServiceBlogId",
                unique: true,
                filter: "[VisaServiceBlogId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IntroBanners");
        }
    }
}
