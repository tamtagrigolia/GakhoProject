using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GakhoProject.Migrations
{
    public partial class Sec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "members",
                columns: new[] { "FullName", "Desc" },
                values: new object[] { "Giorgi", "daibada 1955 weois" });

            migrationBuilder.InsertData(
                table: "members",
                columns: new[] { "FullName", "Desc" },
                values: new object[] { "tamta Gaxaria", "daibada 2002 weois" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "members",
                keyColumn: "FullName",
                keyValue: "Giorgi");

            migrationBuilder.DeleteData(
                table: "members",
                keyColumn: "FullName",
                keyValue: "tamta Gaxaria");
        }
    }
}
