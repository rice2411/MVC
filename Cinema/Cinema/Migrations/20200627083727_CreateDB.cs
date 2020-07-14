using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CinemaManagements",
                columns: table => new
                {
                    screeningID = table.Column<string>(nullable: false),
                    filmId = table.Column<string>(nullable: true),
                    roomId = table.Column<int>(nullable: false),
                    filmName = table.Column<string>(nullable: true),
                    timeStart = table.Column<DateTime>(nullable: false),
                    timeEnd = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CinemaManagements", x => x.screeningID);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    filmId = table.Column<string>(nullable: false),
                    filmName = table.Column<string>(nullable: true),
                    filmPoster = table.Column<string>(nullable: true),
                    filmDescription = table.Column<string>(nullable: true),
                    timeOfFilm = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.filmId);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    roomId = table.Column<string>(nullable: false),
                    statusRoom = table.Column<int>(nullable: false),
                    Seatavailable = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.roomId);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    seatId = table.Column<string>(nullable: false),
                    roomId = table.Column<string>(nullable: true),
                    seatStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.seatId);
                });

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

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "roomId", "Seatavailable", "statusRoom" },
                values: new object[,]
                {
                    { "R01", 50, 0 },
                    { "R02", 50, 0 },
                    { "R03", 50, 0 },
                    { "R04", 50, 0 },
                    { "R05", 50, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CinemaManagements");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Seats");
        }
    }
}
