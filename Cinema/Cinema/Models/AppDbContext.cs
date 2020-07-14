using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
              
        }
        public DbSet<Film> Films { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Screening> CinemaManagements { get; set; }
        public DbSet<Seat> Seats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Film>().HasData(
                    new Film()
                    {
                        filmId = $"{Guid.NewGuid()}",
                        filmName = "End Game",
                        filmPoster ="images/endgame.jpg",
                        timeOfFilm = 182,
                        filmDescription = "Avengers: Hồi kết là phim điện ảnh siêu anh hùng Mỹ ra mắt năm 2019, do Marvel Studios sản xuất và Walt Disney Studios Motion Pictures phân phối. Phim là phần thứ tư của loạt phim Avengers, sau Biệt đội siêu anh hùng, Avengers: Đế chế Ultron và Avengers: Cuộc chiến vô cực."

                    },
                     new Film()
                     {
                         filmId = $"{Guid.NewGuid()}",
                         filmName = "Train to Busan",
                         filmPoster = "images/busan.png",
                         timeOfFilm = 118,
                         filmDescription = "Chuyến tàu sinh tử là một bộ phim về đại dịch zombie của Hàn Quốc được đạo diễn bởi Yeon Sang-ho với sự tham gia các diễn viên Gong Yoo, Jung Yu-mi và Ma Dong-seok. Bộ phim đã được công chiếu trước tại khu vực Midnight Screenings tại Liên hoan phim Cannes 2016 vào ngày 13 tháng 5."

                     },
                      new Film()
                      {
                          filmId = $"{Guid.NewGuid()}",
                          filmName = "NOW YOU SEE ME 2",
                          filmPoster = "images/nowyouseeme.jpg",
                          timeOfFilm = 130,
                          filmDescription = "Phi vụ thế kỷ 2 là phim hành động Mỹ được phát hành của Jon M. Chu. Đây là phần tiếp theo của Phi vụ thế kỷ năm 2013, với sự tham gia của Jesse Eisenberg, Mark Ruffalo, Woody Harrelson, Dave Franco, Daniel Radcliffe, Lizzy Caplan, Jay Chou, Sanaa Lathan và 2 diễn viên gạo cội của Anh và Mỹ: Michael Caine và Morgan ..."

                      },
                      new Film()
                      {
                          filmId = $"{Guid.NewGuid()}",
                          filmName = "Truth Or Dare",
                          filmPoster = "images/truth.jpg",
                          timeOfFilm = 103,
                          filmDescription = "Chơi hay Chết?, là một bộ phim kinh dị siêu nhiên năm 2018 của Mỹ được đạo diễn bởi Jeff Wadlow và được viết bởi Michael Reisz, Jillian Jacobs, Chris Roach và Wadlow."

                      }
                );
            modelBuilder.Entity<Room>().HasData(
                    new Room()
                    {
                        roomId = "R01",
                        statusRoom = StatusRoom.free,
                        Seatavailable = 50,

                    },
                    new Room()
                    {
                        roomId = "R02",
                        statusRoom = StatusRoom.free,
                        Seatavailable = 50,

                    },
                    new Room()
                    {
                        roomId = "R03",
                        statusRoom = StatusRoom.free,
                        Seatavailable = 50,

                    },
                    new Room()
                    {
                        roomId = "R04",
                        statusRoom = StatusRoom.free,
                        Seatavailable = 50,

                    },
                    new Room()
                    {
                        roomId = "R05",
                        statusRoom = StatusRoom.free,
                        Seatavailable = 50,

                    }
                ); ;
        
        }
    }
}
