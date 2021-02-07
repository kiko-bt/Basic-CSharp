using System;
using System.Threading;

namespace Stopwatch
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type 'Start' to begin the stopwatch, or 'Stop' to stop the stopwatch. Type 'Exit' to exit of the program.");

            var userInput = Console.ReadLine();

            Stopwatch stopwatch = new Stopwatch();
            bool isStarted = false;
            bool isAlreadyStarted = false;

            while (userInput.ToLower() != "exit")
            {
                if (userInput.ToLower() == "start")
                {
                    if (isAlreadyStarted)
                    {
                        throw new InvalidOperationException("The application is already started, you can't start twice.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        stopwatch.Start();
                        isStarted = true;
                        isAlreadyStarted = true;
                        Console.WriteLine("Now type 'Stop' if you like to end the timer.");
                        userInput = Console.ReadLine();
                        Console.ResetColor();
                    }
                }
                else if (userInput.ToLower() == "stop")
                {
                    if (isStarted)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        stopwatch.Stop();
                        isStarted = true;
                        isAlreadyStarted = true;
                        Console.WriteLine("Type stop again to get new time.");
                        userInput = Console.ReadLine();
                        isAlreadyStarted = false;
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("You need to start the timer first. Please type 'start'.");
                        Console.Write("Now type start: ");
                        userInput = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("You did not type one of the required words. Please try again.");
                    userInput = Console.ReadLine();
                }
            }




            Console.WriteLine("Thank you for using this application :)");
            Console.ReadLine();
        }
    }
}
