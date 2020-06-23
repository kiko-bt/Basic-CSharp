using HomeWork_Animal.Domain;
using HomeWork_Owner.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HomeWork_Animal.Services
{
    public class AnimalServices
    {
        public Animal[] Animals { get; set; }
        private HelperServices helperService = new HelperServices();

        public AnimalServices()
        {
            Animals = new Animal[]
            {
                new Animal()
                {
                    Name = "Elvis",
                    Species = "Dog",
                    Color = "White",
                },
                new Animal()
                {
                    Name = "Cocan",
                    Species = "Parrot",
                    Color = "Yellow",
                },
                new Animal()
                {
                    Name = "Bo",
                    Species = "Rabbit",
                    Color = "White",
                },
                new Animal()
                {
                    Name = "Lili",
                    Species = "Cat",
                    Color = "Black And White",
                },
                new Animal()
                {
                    Name = "Pepi",
                    Species = "Dog",
                    Color = "Black"
                }
            };
        }



        public Animal OwnerPets(int choosenPet, Owner owner)
        {
            Animal[] newpet = owner.Pets;
            Array.Resize(ref newpet, newpet.Length + 1);
            newpet[newpet.Length - 1] = Animals[choosenPet - 1];
            owner.Pets = newpet;
            return owner.Pets[owner.Pets.Length - 1];
        }



        public void printAnimals()
        {
            int index = 1;
            foreach (Animal pet in Animals)
            {
                Console.WriteLine($"{index++}. {pet.Name} the {pet.Species}");
            }
        }



        public void AdoptedPet(Owner owner)
        {
            foreach (Animal pet in owner.Pets)
            {
                int num = Array.IndexOf(owner.Pets, pet);
                Console.WriteLine($"{num + 1}. {pet.Name} the {pet.Species}");
            }
        }




        public void AdoptAPet(Owner owner)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Please choose an animal. Enter a number between 1 and {Animals.Length}");
                printAnimals();
                int chosenAnimal = helperService.ValidatePositiveNumbers(Console.ReadLine(), Animals.Length);
                if (chosenAnimal >= 1 && chosenAnimal <= Animals.Length)
                {
                    if (helperService.RunAgain() == true)
                    {
                        OwnerPets(chosenAnimal, owner);
                    }
                    else
                    {
                        Console.Clear();
                        OwnerPets(chosenAnimal, owner);
                        Console.WriteLine($"Thank you Mrs / Mr #{owner.FirstName}, please keep your pets save and love them! Here are your pets: ");
                        AdoptedPet(owner);
                        break;
                    }
                }
            }
        }
    }
 }