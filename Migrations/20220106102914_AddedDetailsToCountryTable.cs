using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BirdViewAPI.Migrations
{
    public partial class AddedDetailsToCountryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ISO2",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ISO3",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Countries",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PhoneCode",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Countries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "ISO2",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "ISO3",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "PhoneCode",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Countries");
        }
    }
}
