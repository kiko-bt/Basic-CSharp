using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Animal.Services
{
    public class HelperServices
    {
        public int AgeValidation(string num, int adult)
        {
            int age;
            bool validation = int.TryParse(num, out age);

            if (!validation)
            {
                Console.Clear();
                Console.WriteLine("You must enter your age!");
            }
            else if (num == "" || num == null)
            {
                Console.WriteLine("Invalid input!");
            }
            else if (age <= 18)
            {
                Console.Clear();
                Console.WriteLine("Sorry you're not an adult. You can't adopt a pet! :(");
            }
            else
            {
                Console.WriteLine("Something went wront!");
            }
            return age;
        }



        public bool ValidateStringLength(string value, int range)
        {
            int maxValue = 20;
            if (value.Length < range && range < maxValue) return false;
            return true;
        }


        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }


        public bool RunAgain()
        {
            while (true)
            {
                Console.WriteLine("Would you like to choose another movie? Y/N");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y") return true;
                if (answer == "n") return false;
            }
        }


        public int ValidatePositiveNumbers(string number, int range)
        {
            int result = 0;
            bool isNumber = int.TryParse(number, out result);
            if (!isNumber)
            {
                Console.WriteLine("You must enter a number. Press enter to try again!");
                Console.ReadLine();
                Console.Clear();
                return -1;
            }
            if (result < 1 || result > range)
            {
                Console.WriteLine("You must enter a number. Press enter to try again!");
                Console.ReadLine();
                Console.Clear();
                return -1;
            }
            return result;
        }
    }
}
