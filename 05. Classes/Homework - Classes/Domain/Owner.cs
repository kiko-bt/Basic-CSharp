using System;
using System.Collections.Generic;
using System.Text;

namespace Homework___Owner
{
    class Owner
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string Address;
        public string[] ArrPets = {"rabbit", "dog", "cat", "mouse", "parrot"};
        public string City;

        public void FullInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}, lives in the city of {City} on address {Address}");
        }
    }
}
