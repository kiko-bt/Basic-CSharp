using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreApp.Services
{
    public class HelperService
    {
        public int Login(int num)
        {
            while (true)
            {
                int number;
                bool numberValidation = int.TryParse(Console.ReadLine(), out number);
                
                if (number == 1)
                {
                    Console.WriteLine("Welcome Dear Employee");
                    break;
                }
                else if (number == 2)
                {
                    Console.WriteLine("Welcome Dear User");
                    break;
                }
                if (number != 1 || number != 2)
                {
                    Console.WriteLine("Ooops... something went wrong. Try Again \n Press 1 or 2");
                }
            }
            return num;
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
                Console.WriteLine("Press enter to try again!");
                Console.ReadLine();
                Console.Clear();
                return -1;
            }
            if (result < 1 || result > range)
            {
                Console.WriteLine("The number is out of range. Press enter to try again!");
                Console.ReadLine();
                Console.Clear();
                return -1;
            }
            return result;
        }


    }
}
