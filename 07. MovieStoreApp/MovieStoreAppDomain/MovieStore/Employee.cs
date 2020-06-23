using MovieStoreApp.Domain.MovieStore.Member;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreApp.Domain.Employee
{
    public class Employee : Member
    {
        private int Salary { get; set; }
        public int HoursPerMonth { get; set; }
        public double Bonus { get; set; }

        public void SetBonus()
        {
            if (HoursPerMonth > 160)
            {
                Bonus = 0.3;
            }
            else if (HoursPerMonth < 160)
            {
                Bonus = 0;
            }
        }


        public int SetSalary(int hours, int bonus)
        {
            Salary = hours * bonus;
            return Salary;
        }


        public Employee(string firstName, string lastName, int age, string userName, string password, int phoneNumber)
            : base(firstName, lastName, age, userName, password, phoneNumber)
        {
            Salary = 300;
        }

        public Employee()
        {

        }
    }
}
