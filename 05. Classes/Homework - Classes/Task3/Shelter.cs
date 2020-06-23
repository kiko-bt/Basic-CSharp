using System;
using System.Collections.Generic;
using System.Text;


namespace Homework___Classes.Task3
{
    class Shelter
    {
        public string[] Pets = { "Bill the dog", "Jane the cat", "Mickey the mouse", "Koki the Parrot", "Riri the Rabbit"};
        public string FirstName;
        public string LastName;
        public string City;
        public string Address;

        public void User()
        {
            Console.WriteLine("Enter the First Name");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter the City");
            City = Console.ReadLine();
            Console.WriteLine("Enter the address");
            Address = Console.ReadLine();

            Console.WriteLine($"{FirstName} {LastName} from {City} lives in {Address}");
        }
    }
}
