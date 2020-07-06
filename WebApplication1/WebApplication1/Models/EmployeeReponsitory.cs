using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class EmployeeReponsitory : IEmployeeReponsitory
    {
        private List<Employee> employees;
        public EmployeeReponsitory()
        {
            employees = new List<Employee>()
            {
                new Employee()
                {
                   id = 1,
                   Name= "Anh Minh",
                   FullName="Tôn Thất Anh Minh",
                   DOB=new DateTime(2001,11,24),
                   Email="minh@gmail.com",
                   Avatar="~/images/avatar.png",
                   Department =DPM.IT
                   
                },
               
               new Employee()   {
                    id = 2,
                    Name="Nhật Trang",
                    FullName= "Hồ Thị Nhật Trang",
                    DOB = new DateTime(2001,06,15),
                    Email="Trang@gmail.com",
                    Avatar="~/images/avatar2.png",
                    Department =DPM.QA
                },
                new Employee()   {
                    id = 3,
                    Name="Thanh Thanh",
                    FullName= "Văn Vũ Thanh Thanh",
                    DOB = new DateTime(2001,02,28),
                    Email="Thanh@gmail.com",
                    Avatar="~/images/avatar2.png",
                    Department =DPM.QA
                },
                 new Employee()   {
                    id = 4,
                    Name ="Gia Tuệ",
                    FullName= "Dương Gia Tuệ",
                    DOB = new DateTime(2001,07,18),
                    Email="Tue@gmail.com",
                    Avatar="~/images/avatar2.png",
                    Department =DPM.QA             
                }
                 
            };
        }
        public IEnumerable<Employee> Gets()
        {
            return employees;
        }
        public Employee Get(int id)
        {
            return employees.FirstOrDefault(e => e.id == id);
        }
        
        public Employee Create(Employee e)
        {
            e.id = employees.Max(e => e.id) + 1;
            e.Avatar = "~/images/avatar2.png";
            employees.Add(e);
            return e;
        }
        public Employee Edit(Employee e)
        {
            var emp = Get(e.id);
            emp.Name = e.Name;
            emp.FullName = e.FullName;
            emp.Email = e.Email;
            emp.DOB = e.DOB;
            emp.Department = e.Department;
            return emp;
        }

        public bool Delete(int id)
        {
            var emp = Get(id);
            if(emp!=null)
            {
                employees.Remove(emp);
                return true;
            }
            return false; 
        }
    }
}
