using System;
using HomeWork__Animals;
using Homework___Owner;
using Homework___Classes.Task3;

namespace Homework___Classes
{

    class EntryPoint
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Name = "Jackie";
            animal.Spicie = "labrador";
            animal.Color = "fawn";
            animal.FavoriteFood = "Meat and Snacks";

            animal.Eat("Meat and Snacks");
            animal.Sleep("6", "8");



            Owner owner = new Owner();
            owner.FirstName = "Jack";
            owner.LastName = "Doe";
            owner.Age = 38;
            owner.Address = "Ridge St";
            owner.City = "New York City";

            for (int i = 0; i < owner.ArrPets.Length; i++)
            {
                Console.WriteLine(owner.ArrPets[i]);
            }

            owner.FullInfo();




            #region Shelter


            Shelter user = new Shelter();
            NewOwner theBoss = new NewOwner();
            user.User();
            theBoss.Owner();

          

            //shelter.Pets[0] = shelter.Pets[ask];

            #endregion



            Console.ReadLine();
        }
    }
}
