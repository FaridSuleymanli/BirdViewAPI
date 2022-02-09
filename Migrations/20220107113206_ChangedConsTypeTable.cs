using Microsoft.EntityFrameworkCore.Migrations;

namespace BirdViewAPI.Migrations
{
    public partial class ChangedConsTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConsultationType_VisaTypes_VisatypeId",
                table: "ConsultationType");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryServices_ConsultationServices_ConsultationServiceId",
                table: "CountryServices");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryServices_ConsultationType_ConsultationTypeId",
                table: "CountryServices");

            migrationBuilder.DropTable(
                name: "ConsultationServices");

            migrationBuilder.DropIndex(
                name: "IX_CountryServices_ConsultationServiceId",
                table: "CountryServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConsultationType",
                table: "ConsultationType");

            migrationBuilder.RenameTable(
                name: "ConsultationType",
                newName: "ConsultationTypes");

            migrationBuilder.RenameIndex(
                name: "IX_ConsultationType_VisatypeId",
                table: "ConsultationTypes",
                newName: "IX_ConsultationTypes_VisatypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConsultationTypes",
                table: "ConsultationTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ConsultationTypes_VisaTypes_VisatypeId",
                table: "ConsultationTypes",
                column: "VisatypeId",
                principalTable: "VisaTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryServices_ConsultationTypes_ConsultationTypeId",
                table: "CountryServices",
                column: "ConsultationTypeId",
                principalTable: "ConsultationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConsultationTypes_VisaTypes_VisatypeId",
                table: "ConsultationTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryServices_ConsultationTypes_ConsultationTypeId",
                table: "CountryServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConsultationTypes",
                table: "ConsultationTypes");

            migrationBuilder.RenameTable(
                name: "ConsultationTypes",
                newName: "ConsultationType");

            migrationBuilder.RenameIndex(
                name: "IX_ConsultationTypes_VisatypeId",
                table: "ConsultationType",
                newName: "IX_ConsultationType_VisatypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConsultationType",
                table: "ConsultationType",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ConsultationServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisatypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultationServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsultationServices_VisaTypes_VisatypeId",
                        column: x => x.VisatypeId,
                        principalTable: "VisaTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CountryServices_ConsultationServiceId",
                table: "CountryServices",
                column: "ConsultationServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultationServices_VisatypeId",
                table: "ConsultationServices",
                column: "VisatypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConsultationType_VisaTypes_VisatypeId",
                table: "ConsultationType",
                column: "VisatypeId",
                principalTable: "VisaTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryServices_ConsultationServices_ConsultationServiceId",
                table: "CountryServices",
                column: "ConsultationServiceId",
                principalTable: "ConsultationServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryServices_ConsultationType_ConsultationTypeId",
                table: "CountryServices",
                column: "ConsultationTypeId",
                principalTable: "ConsultationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
