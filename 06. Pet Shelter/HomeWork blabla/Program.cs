using HomeWork_Animal.Domain;
using HomeWork_Animal.Services;
using HomeWork_Owner.Domain;
using System;

namespace HomeWork_blabla
{
    public class Program
    {
        private static AnimalServices AnimalService = new AnimalServices();
        private static OwnerServices OwnerService = new OwnerServices();
        private static HelperServices HelperService = new HelperServices();
        private static Owner _loggedOwner = new Owner();


        static void Main(string[] args)
        {

            Owner newOwner = new Owner();

            while (true)
            {
                Console.WriteLine("*Hello sir Welcome to the Pet Shelter*");
                Console.WriteLine(new string('-', 40));

                Console.WriteLine("Enter Your First Name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter Your Last Name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter Your City: ");
                string city = Console.ReadLine();
                Console.WriteLine("Enter Your Address: ");
                string address = Console.ReadLine();
                Console.WriteLine("Enter your Age: ");
                int age = HelperService.AgeValidation(Console.ReadLine(), 18);


                newOwner.FirstName = firstName;
                newOwner.LastName = lastName;
                newOwner.City = city;
                newOwner.Address = address;
                newOwner.Age = age;
                _loggedOwner = OwnerService.LogIn(newOwner);

                if (firstName == "" || firstName == null)
                {
                    Console.Clear();
                    HelperService.Error("Invalid First Name. Try Again!");
                    break;
                }
                else if (lastName == "" || lastName == null)
                {
                    Console.Clear();
                    HelperService.Error("Invalid Last Name. Try Again!");
                    break;
                }
                else if (city == "" || city == null)
                {
                    Console.Clear();
                    HelperService.Error("Invalid City. Try Again!");
                    break;
                }
                else if (address == "" || address == null)
                {
                    Console.Clear();
                    HelperService.Error("Invalid Adress. Try Again!");
                    break;
                }
                else if (newOwner.Age >= 18)
                {
                    Console.Clear();
                    Console.WriteLine($"Welcome {newOwner.FirstName} {newOwner.LastName}");
                    AnimalService.AdoptAPet(_loggedOwner);
                    break;
                }
            }
        }
    }
}
