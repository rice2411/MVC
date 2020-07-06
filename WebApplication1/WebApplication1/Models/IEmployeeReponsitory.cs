using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
   public interface IEmployeeReponsitory
    {
        IEnumerable<Employee> Gets();
        Employee Get(int id);
        Employee Create(Employee e);
        Employee Edit(Employee e);
        bool Delete(int id);
    }
}
