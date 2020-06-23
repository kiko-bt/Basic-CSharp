using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreApp.Domain.ENUM;

namespace MovieStoreApp.Domain.MovieStore.Member
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public Role Roles { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} {DateOfRegistration}");
        }



        public Member()
        {

        }


        public Member(string firstName, string lastName, int age, string userName, string password, int phoneNumber)
        {
            Console.WriteLine("Constructor with parameters from Members");

            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = password;
            PhoneNumber = phoneNumber;
            DateOfRegistration = DateTime.Today;
        }
    }
}
