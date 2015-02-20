using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowEmplopyeeInGridView
{
   public class Employee
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public Employee(string name, string address, string phone)
        {
            this.Name = name;
            this.Address = address;
            this.Phone = phone;

        }




        public List<Employee> SavEmployees(Employee aEmployee)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(aEmployee);
            return employees;
        }
     
    }
}
