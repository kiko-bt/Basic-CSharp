using System;



namespace HomeWork__Animals
{
    class Animal
    {
      
        public void Eat(string food)
        {
            Console.WriteLine("{0} the {1} wants to eat {2}", Name, Spicie, food);
        }

        public void Sleep(string from, string till)
        {
            Console.WriteLine("{0} the {1} sleeps from {2} till {3} hours", Name, Spicie, from, till);
        }
    }
}