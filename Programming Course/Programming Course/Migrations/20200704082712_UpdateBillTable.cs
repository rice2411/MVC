using Microsoft.EntityFrameworkCore.Migrations;

namespace Programming_Course.Migrations
{
    public partial class UpdateBillTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_AspNetUsers_userId",
                table: "Bills");

            migrationBuilder.DropIndex(
                name: "IX_Bills_userId",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Bills",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "customerAddress",
                table: "Bills",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "customerName",
                table: "Bills",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "customerPhoneNumber",
                table: "Bills",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bills_ApplicationUserId",
                table: "Bills",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_AspNetUsers_ApplicationUserId",
                table: "Bills",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_AspNetUsers_ApplicationUserId",
                table: "Bills");

            migrationBuilder.DropIndex(
                name: "IX_Bills_ApplicationUserId",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "customerAddress",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "customerName",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "customerPhoneNumber",
                table: "Bills");

            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "Bills",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_userId",
                table: "Bills",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_AspNetUsers_userId",
                table: "Bills",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
