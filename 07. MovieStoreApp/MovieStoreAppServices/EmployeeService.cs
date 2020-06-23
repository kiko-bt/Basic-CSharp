using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreApp.Domain.Employee;



namespace MovieStoreApp.Services
{
    public class EmployeeService
    {
        public Employee[] Employees { get; set; }
        public EmployeeService()
        {
            Employees = new Employee[]
            {
                new Employee()
                {
                    FirstName = "Hristijan",
                    LastName = "Petrovski",
                    Age = 25,
                    UserName = "Kiko-bt",
                    Password = "SlavkoLumbarko16",
                    PhoneNumber = 047-255-642
                },
                new Employee()
                {
                    FirstName = "Marko",
                    LastName = "Zdravevski",
                    Age = 27,
                    UserName = "Marko.batkata",
                    Password = "SlavkoLumbarko18",
                    PhoneNumber = 047-222-664
                }
            };
        }

   
        

        public Employee Login(string username, string password)
        {
            foreach (Employee employee in Employees)
            {
                if (employee.UserName == username && employee.Password == password)
                    return employee;
            }
            return null;
        }



        public void EmployeeName()
        {
            foreach (Employee me in Employees)
            {
                me.DisplayInfo();
            }
            Console.WriteLine("1. See all the registered members in the movie store \n 2. See all the movies available for renting \n 3. Add new members \n 4. Delete existing members");
        }
    }
}
