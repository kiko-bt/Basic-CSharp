using System;
using System.Collections.Generic;
using System.Text;


namespace Homework___Classes.Task3
{
    class NewOwner
    {
        public int yearsOld = 18;

        public void Owner()
        {
            Shelter shelter = new Shelter();

            Console.WriteLine("How old are you?");
            int askForYears = Convert.ToInt32(Console.ReadLine());
            if (askForYears >= yearsOld)
            {
                for (int i = 0; i < shelter.Pets.Length; i++)
                {
                    Console.WriteLine(shelter.Pets[i]);
                }
            }
            else
            {
                Console.WriteLine("You're not an adult! Sorry...");
            }
        }
    }
}
