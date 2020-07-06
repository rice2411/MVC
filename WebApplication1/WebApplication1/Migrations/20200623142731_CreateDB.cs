    using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    FullName = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Department = table.Column<int>(nullable: false),
                    Avatar = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "id", "Age", "Avatar", "DOB", "Department", "Email", "FullName", "Name" },
                values: new object[,]
                {
                    { 1, 0, "~/images/avatar.png", new DateTime(2001, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "minh@gmail.com", "Tôn Thất Anh Minh", "Anh Minh" },
                    { 2, 0, "~/images/avatar2.png", new DateTime(2001, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Trang@gmail.com", "Hồ Thị Nhật Trang", "Nhật Trang" },
                    { 3, 0, "~/images/avatar2.png", new DateTime(2001, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Thanh@gmail.com", "Văn Vũ Thanh Thanh", "Thanh Thanh" },
                    { 4, 0, "~/images/avatar2.png", new DateTime(2001, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Tue@gmail.com", "Dương Gia Tuệ", "Gia Tuệ" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
