using System;
using System.Collections.Generic;
using System.Text;
using HomeWork_Animal.Domain;

namespace HomeWork_Owner.Domain
{
    public class Owner
    {
        public string FirstName {get; set;}
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Animal[] Pets { get; set; }
        public string City { get; set; }

        public Owner()
        {
            Pets = new Animal[0];
        }
       
        public string FullInfo()
        {
            return $"{FirstName} {LastName}, lives in the city of {City} on address {Address}";
        }


    }
}
