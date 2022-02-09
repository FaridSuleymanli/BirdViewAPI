using Microsoft.EntityFrameworkCore.Migrations;

namespace BirdViewAPI.Migrations
{
    public partial class CreatedHoverImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HoverImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TagLine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoverImagesUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisaServiceBlogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoverImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoverImages_VisaServiceBlogs_VisaServiceBlogId",
                        column: x => x.VisaServiceBlogId,
                        principalTable: "VisaServiceBlogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoverImages_VisaServiceBlogId",
                table: "HoverImages",
                column: "VisaServiceBlogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoverImages");
        }
    }
}
