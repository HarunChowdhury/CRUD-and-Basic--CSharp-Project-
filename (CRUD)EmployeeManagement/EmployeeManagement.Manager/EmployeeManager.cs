using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Model;

namespace EmployeeManagement.Manager
{
   public  class EmployeeManager
    {
       private EmployeeManagementDb2Entities Db;
        public EmployeeManager()
        {
            Db = new EmployeeManagementDb2Entities();
        }


        public void Add(Employee aEmployee)
        {
            //Employee e = (from employeelist in Db.Employees
            //              where employeelist.Name == aEmployee.Name
            //              select employeelist).FirstOrDefault(); 

            List<Employee> employeeslist = Db.Employees.ToList();

            DbSet<Employee> employees = Db.Employees;
            foreach (Employee em in employeeslist) 
            {
                if (aEmployee.Name!=em.Name ) 
               {
                employees.Add(aEmployee);
               }

              Db.SaveChanges();

             }

        }

        public List<Employee> GetEmployeeList()
        {
            return Db.Employees.ToList();
        }

        public void Delete(int id)
        {
            Employee aEmployee = (from employees in Db.Employees
                                  where employees.Id == id
                                  select employees).FirstOrDefault();
            if (aEmployee != null)
            {
                Db.Employees.Remove(aEmployee);
            }

            Db.SaveChanges();

            // Employee aEmployee = Db.Employees.FirstOrDefault(e=>e.Id==id);
            // Employee aEmployee = (Db.Employees.Where(e => e.Id == id)).FirstOrDefault();

        }

    }
}
