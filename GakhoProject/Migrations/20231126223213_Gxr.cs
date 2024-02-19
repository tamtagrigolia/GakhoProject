using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GakhoProject.Migrations
{
    public partial class Gxr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
   

            migrationBuilder.CreateTable(
                name: "members",
                columns: table => new
                {
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_members", x => x.FullName);
                });

            migrationBuilder.InsertData(
                table: "members",
                columns: new[] { "FullName", "Desc" },
                values: new object[] { "tamta grigolia", "daibada 2002 weois" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
 

          
        }
    }
}
