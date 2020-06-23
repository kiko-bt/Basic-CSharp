using System;
using System.Collections.Generic;
using System.Text;
using HomeWork_Owner.Domain;

namespace HomeWork_Animal.Domain
{
    public class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Color { get; set; }
        public string FavoriteFood { get; set; }

        public Animal()
        {
            FavoriteFood = "Meet and Snacks";
        }
        public string Eat(string food)
        {
            return $"{Name} the {Species} wants to eat {food}";
        }

        public string Sleep(string from, string till)
        {
            return $"{Name} the {Species} sleeps from {from} till {till} hours";
        }
    }
}
