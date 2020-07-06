using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser  >
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData(
                new Employee()
                {
                    id = 1,
                    Name = "Anh Minh",
                    FullName = "Tôn Thất Anh Minh",
                    DOB = new DateTime(2001, 11, 24),
                    Email = "minh@gmail.com",
                    Avatar = "~/images/avatar.png",
                    Department = DPM.IT
                    
                },

               new Employee()
               {
                   id = 2,
                   Name = "Nhật Trang",
                   FullName = "Hồ Thị Nhật Trang",
                   DOB = new DateTime(2001, 06, 15),
                   Email = "Trang@gmail.com",
                   Avatar = "~/images/avatar2.png",
                   Department = DPM.QA
               },
                new Employee()
                {
                    id = 3,
                    Name = "Thanh Thanh",
                    FullName = "Văn Vũ Thanh Thanh",
                    DOB = new DateTime(2001, 02, 28),
                    Email = "Thanh@gmail.com",
                    Avatar = "~/images/avatar2.png",
                    Department = DPM.QA
                },
                 new Employee()
                 {
                     id = 4,
                     Name = "Gia Tuệ",
                     FullName = "Dương Gia Tuệ",
                     DOB = new DateTime(2001, 07, 18),
                     Email = "Tue@gmail.com",
                     Avatar = "~/images/avatar2.png",
                     Department = DPM.QA
                 }

            );
          
        }
    }
}
