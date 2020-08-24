using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApiCRUD.Models
{
   public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee Get(int id);
        Employee Add(Employee employee);
        bool Contains(int id);
        void Remove(int id);
        Employee Update(int id,Employee employee);
    }
}
