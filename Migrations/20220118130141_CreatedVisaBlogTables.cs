using Microsoft.EntityFrameworkCore.Migrations;

namespace BirdViewAPI.Migrations
{
    public partial class CreatedVisaBlogTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdditionalInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TagLine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalInfoImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisaServBlogId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalInfos_VisaServiceBlogs_VisaServBlogId",
                        column: x => x.VisaServBlogId,
                        principalTable: "VisaServiceBlogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CountAndTitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(type: "int", nullable: false),
                    RemoveImage = table.Column<bool>(type: "bit", nullable: false),
                    VisaServiceBlogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountAndTitles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CountAndTitles_VisaServiceBlogs_VisaServiceBlogId",
                        column: x => x.VisaServiceBlogId,
                        principalTable: "VisaServiceBlogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SliderImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisaServiceBlogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sliders_VisaServiceBlogs_VisaServiceBlogId",
                        column: x => x.VisaServiceBlogId,
                        principalTable: "VisaServiceBlogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WalkInProcesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WalkInProcessImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisaServiceBlogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalkInProcesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WalkInProcesses_VisaServiceBlogs_VisaServiceBlogId",
                        column: x => x.VisaServiceBlogId,
                        principalTable: "VisaServiceBlogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalInfos_VisaServBlogId",
                table: "AdditionalInfos",
                column: "VisaServBlogId");

            migrationBuilder.CreateIndex(
                name: "IX_CountAndTitles_VisaServiceBlogId",
                table: "CountAndTitles",
                column: "VisaServiceBlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Sliders_VisaServiceBlogId",
                table: "Sliders",
                column: "VisaServiceBlogId");

            migrationBuilder.CreateIndex(
                name: "IX_WalkInProcesses_VisaServiceBlogId",
                table: "WalkInProcesses",
                column: "VisaServiceBlogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalInfos");

            migrationBuilder.DropTable(
                name: "CountAndTitles");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "WalkInProcesses");
        }
    }
}
