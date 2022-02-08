using Microsoft.EntityFrameworkCore.Migrations;

namespace StackBlog.Data.Migrations
{
    public partial class Initialize1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Header",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "SubHeader",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubHeader",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Header",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
