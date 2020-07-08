using Microsoft.EntityFrameworkCore.Migrations;

namespace Programming_Course.Migrations
{
    public partial class AddColoumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "couresName",
                table: "Bills",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "couresName",
                table: "Bills");
        }
    }
}
