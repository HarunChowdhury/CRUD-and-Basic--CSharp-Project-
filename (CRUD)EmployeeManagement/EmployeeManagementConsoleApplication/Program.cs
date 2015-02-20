using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Manager;
using EmployeeManagement.Model;

namespace EmployeeManagementConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string name, idNo, address, phone, desination;
            Console.Write("Name:");
            name = Console.ReadLine();
            Console.Write("Id No:");          
            idNo = Console.ReadLine();
            Console.Write("Address:");     
            address = Console.ReadLine();
            Console.Write("Phone:");         
            phone = Console.ReadLine();
            Console.Write("Designation:");         
            desination = Console.ReadLine();
       


             Employee aEmployee = new Employee() { Name = name, EmployeeCardNo = idNo, Address = address, Phone = phone, Designation = desination };
            // Employee aEmployee1 = new Employee() { Name = "Salam", EmployeeCardNo = "EMP_003", Address = "Rangpur", Phone = "0175351056864", Designation = "Senior Software Eng." };

              EmployeeManager manager = new EmployeeManager();
              
              manager.Add(aEmployee);

              Console.WriteLine("Save Successfull\n\n");

              Console.Write("Enter Employee Id:");
              manager.Delete(Convert.ToInt32(Console.ReadLine()));
              Console.Write("\nEntered Employee Id Has been deleted.\n");

             

             List<Employee> aEmployee2 = manager.GetEmployeeList();
            foreach (Employee employee in aEmployee2)
            {
                Console.WriteLine("Name :" + employee.Name + " ID Card :" + employee.EmployeeCardNo);
            }

         

            Console.WriteLine("\nRetrive Successfull");
          


            Console.ReadKey();
        }
    }
}
