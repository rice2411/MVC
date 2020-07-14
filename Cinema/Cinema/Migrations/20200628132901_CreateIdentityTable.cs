using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Migrations
{
    public partial class CreateIdentityTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "filmId",
                keyValue: "0764ecae-677c-4cf7-b796-a603e667631f");

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "filmId",
                keyValue: "61d0f453-5012-47ad-90b8-7703b6f88b30");

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "filmId",
                keyValue: "9308962d-351d-4080-8424-6330f74396bd");

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "filmId",
                keyValue: "957ad7cb-1d34-42ee-8b9d-1fe22ca1f6c7");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "filmId", "filmDescription", "filmName", "filmPoster", "timeOfFilm" },
                values: new object[,]
                {
                    { "c5e5efa6-95de-4cdc-ba85-6962dda4d688", "Avengers: Hồi kết là phim điện ảnh siêu anh hùng Mỹ ra mắt năm 2019, do Marvel Studios sản xuất và Walt Disney Studios Motion Pictures phân phối. Phim là phần thứ tư của loạt phim Avengers, sau Biệt đội siêu anh hùng, Avengers: Đế chế Ultron và Avengers: Cuộc chiến vô cực.", "End Game", "images/endgame.jpg", 182 },
                    { "f1da2f1e-a901-4426-a439-24d865a99898", "Chuyến tàu sinh tử là một bộ phim về đại dịch zombie của Hàn Quốc được đạo diễn bởi Yeon Sang-ho với sự tham gia các diễn viên Gong Yoo, Jung Yu-mi và Ma Dong-seok. Bộ phim đã được công chiếu trước tại khu vực Midnight Screenings tại Liên hoan phim Cannes 2016 vào ngày 13 tháng 5.", "Train to Busan", "images/busan.png", 118 },
                    { "42f5a3fd-7495-410b-9722-1c0c7e874b72", "Phi vụ thế kỷ 2 là phim hành động Mỹ được phát hành của Jon M. Chu. Đây là phần tiếp theo của Phi vụ thế kỷ năm 2013, với sự tham gia của Jesse Eisenberg, Mark Ruffalo, Woody Harrelson, Dave Franco, Daniel Radcliffe, Lizzy Caplan, Jay Chou, Sanaa Lathan và 2 diễn viên gạo cội của Anh và Mỹ: Michael Caine và Morgan ...", "NOW YOU SEE ME 2", "images/nowyouseeme.jpg", 130 },
                    { "256c4bce-9028-42ef-927a-b12fca9a9241", "Chơi hay Chết?, là một bộ phim kinh dị siêu nhiên năm 2018 của Mỹ được đạo diễn bởi Jeff Wadlow và được viết bởi Michael Reisz, Jillian Jacobs, Chris Roach và Wadlow.", "Truth Or Dare", "images/truth.jpg", 103 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "filmId",
                keyValue: "256c4bce-9028-42ef-927a-b12fca9a9241");

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "filmId",
                keyValue: "42f5a3fd-7495-410b-9722-1c0c7e874b72");

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "filmId",
                keyValue: "c5e5efa6-95de-4cdc-ba85-6962dda4d688");

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "filmId",
                keyValue: "f1da2f1e-a901-4426-a439-24d865a99898");

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "filmId", "filmDescription", "filmName", "filmPoster", "timeOfFilm" },
                values: new object[,]
                {
                    { "9308962d-351d-4080-8424-6330f74396bd", "Avengers: Hồi kết là phim điện ảnh siêu anh hùng Mỹ ra mắt năm 2019, do Marvel Studios sản xuất và Walt Disney Studios Motion Pictures phân phối. Phim là phần thứ tư của loạt phim Avengers, sau Biệt đội siêu anh hùng, Avengers: Đế chế Ultron và Avengers: Cuộc chiến vô cực.", "End Game", "images/endgame.jpg", 182 },
                    { "957ad7cb-1d34-42ee-8b9d-1fe22ca1f6c7", "Chuyến tàu sinh tử là một bộ phim về đại dịch zombie của Hàn Quốc được đạo diễn bởi Yeon Sang-ho với sự tham gia các diễn viên Gong Yoo, Jung Yu-mi và Ma Dong-seok. Bộ phim đã được công chiếu trước tại khu vực Midnight Screenings tại Liên hoan phim Cannes 2016 vào ngày 13 tháng 5.", "Train to Busan", "images/busan.png", 118 },
                    { "61d0f453-5012-47ad-90b8-7703b6f88b30", "Phi vụ thế kỷ 2 là phim hành động Mỹ được phát hành của Jon M. Chu. Đây là phần tiếp theo của Phi vụ thế kỷ năm 2013, với sự tham gia của Jesse Eisenberg, Mark Ruffalo, Woody Harrelson, Dave Franco, Daniel Radcliffe, Lizzy Caplan, Jay Chou, Sanaa Lathan và 2 diễn viên gạo cội của Anh và Mỹ: Michael Caine và Morgan ...", "NOW YOU SEE ME 2", "images/nowyouseeme.jpg", 130 },
                    { "0764ecae-677c-4cf7-b796-a603e667631f", "Chơi hay Chết?, là một bộ phim kinh dị siêu nhiên năm 2018 của Mỹ được đạo diễn bởi Jeff Wadlow và được viết bởi Michael Reisz, Jillian Jacobs, Chris Roach và Wadlow.", "Truth Or Dare", "images/truth.jpg", 103 }
                });
        }
    }
}
