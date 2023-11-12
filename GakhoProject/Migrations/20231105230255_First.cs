using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GakhoProject.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YourFullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PartiesName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "classes",
                columns: new[] { "Id", "DateOfBirth", "PartiesName", "YourFullName" },
                values: new object[] { 1, new DateTime(1792, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForGeo", "tamta grigolia" });

            migrationBuilder.InsertData(
                table: "classes",
                columns: new[] { "Id", "DateOfBirth", "PartiesName", "YourFullName" },
                values: new object[] { 2, new DateTime(1792, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Georgia dream", "irakli kobaxidze" });

            migrationBuilder.InsertData(
                table: "classes",
                columns: new[] { "Id", "DateOfBirth", "PartiesName", "YourFullName" },
                values: new object[] { 3, new DateTime(1792, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForGeo", "giorgi gaxaria" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "classes");
        }
    }
}
