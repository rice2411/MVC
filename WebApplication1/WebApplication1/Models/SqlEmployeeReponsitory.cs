using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class SqlEmployeeReponsitory : IEmployeeReponsitory
    {
        private readonly AppDbContext context;
        public SqlEmployeeReponsitory(AppDbContext context)
        {
            this.context = context;
            //foreach (var e in context.Employees)
            //    e.Cal();
        }
        public Employee Create(Employee e)
        {
            context.Employees.Add(e);
            context.SaveChanges();
            return e;
        }

        public bool Delete(int id)
        {
            var deleteEmp = context.Employees.Find(id);
            if(deleteEmp !=null)
            {
                context.Employees.Remove(deleteEmp);
                return context.SaveChanges() > 0;
            }
            return false;
        }

        public Employee Edit(Employee emp)
        {
            var editEmp = context.Employees.Attach(emp);
            editEmp.State = EntityState.Modified;
            context.SaveChanges();
            return emp;
        }

        public Employee Get(int id)
        {
            return context.Employees.Find(id);
        }

        public IEnumerable<Employee> Gets()
        {
            return context.Employees;
        }
    }
}
