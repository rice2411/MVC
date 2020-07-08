using Microsoft.EntityFrameworkCore.Migrations;

namespace Programming_Course.Migrations
{
    public partial class UpdateColumnRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "role",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "role",
                table: "Employees");
        }
    }
}
