using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApiCRUD.Models
{
    public class InMemoryEmployeeRepository : IEmployeeRepository
    {

        

        Dictionary<long,Employee> employees = new Dictionary<long, Employee>();

        private int _Id = 1;

        public InMemoryEmployeeRepository()
        {
            //Add(new Employee { Name = "Naveen", Salary = 30000, Location= "Noida" });
            //Add(new Employee { Name = "Mahesh", Salary = 40000, Location = "Hyd" });
            //Add(new Employee { Name = "Ramesh", Salary = 50000, Location = "Chennai" });
        }


        public Employee Add(Employee employee)
        {
            if (employee== null)
            {
                throw new ArgumentNullException("employee");
            }
            employee.Id = _Id++;
            employees.Add(_Id,employee);
            return employee;
        }

        public bool Contains(int id)
        {
            return employees.ContainsKey(id); 
        }

        public Employee Get(int id)
        {
            return employees.GetValueOrDefault(id);
        }

        public IEnumerable<Employee> GetAll()
        {
          var employeeslst = new List<Employee>();
            foreach (var emp in employees)
            {
                employeeslst.Add(emp.Value);
            }
            return employeeslst;
        }

        public void Remove(int id)
        {
           employees.Remove(id);
        }

        public Employee Update(int id,Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException("employee");
            }
            employee.Id = id;
            employees[id] = employee;

            return employee;
        }
    }
}
