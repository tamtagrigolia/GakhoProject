using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GakhoProject.Migrations
{
    public partial class RoleSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8d1b6b18-80a1-44ac-a0c8-3dc908c9dae2", "8d159136-d38a-4bb0-8e5e-5dddbd55dce8", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ef1e1cf3-3460-4c37-96e9-b0f6574cafe2", "d2c61181-edba-4609-87c9-4c23c3d887f8", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d1b6b18-80a1-44ac-a0c8-3dc908c9dae2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef1e1cf3-3460-4c37-96e9-b0f6574cafe2");
        }
    }
}
