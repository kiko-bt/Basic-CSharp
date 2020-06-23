using HomeWork_Owner.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Animal.Services
{
    public class OwnerServices
    {
        private HelperServices helperservice = new HelperServices();
        public Owner[] Owner { get; set; }

        public OwnerServices()
        {
            Owner = new Owner[]
            {
                new Owner()
                {
                    FirstName = "Jack",
                    LastName = "Doe",
                    Age = 29,
                    Address = "Ridge St",
                    City = "New York City",
                },
            };
        }
    
        public Owner LogIn(Owner owner)
        {
            if (!helperservice.ValidateStringLength(owner.FirstName, 2) ||
                !helperservice.ValidateStringLength(owner.LastName, 2) ||
                !helperservice.ValidateStringLength(owner.Address, 4))
            {
                return null;
            }
            else
            {
                Owner[] array = Owner;
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = owner;
                Owner = array;
                return Owner[Owner.Length - 1];
            }
        }


        
    }
}
