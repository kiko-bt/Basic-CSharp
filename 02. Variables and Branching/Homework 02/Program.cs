using System;

namespace Homework_02
{
class Program
{
static void Main(string[] args)
{
            //Task 1 “RealCalculator”

            int firstNumber;
            int secondNumber;
            bool validation;

            string operation;
            int result;

            Console.WriteLine("Enter two numbers and calculate");

            do
            {
                Console.WriteLine("Enter first number:");
                validation = Int32.TryParse(Console.ReadLine(), out firstNumber);
                if (!validation) Console.WriteLine("Please enter numbers only!");
                else break;
            } while (true);

            do
            {
                Console.WriteLine("Enter second number:");
                validation = Int32.TryParse(Console.ReadLine(), out secondNumber);
                if (!validation) Console.WriteLine("Please enter numbers only!");
                else break;
            } while (true);

            Console.WriteLine("Enter your operation ( +, - , * , / )");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    Console.WriteLine("Result: " + result);
                    break;

                case "-":
                    result = firstNumber - secondNumber;
                    Console.WriteLine("Result: " + result);
                    break;

                case "*":
                    result = firstNumber * secondNumber;
                    Console.WriteLine("Result: " + result);
                    break;

                case "/":
                    result = firstNumber / secondNumber;
                    Console.WriteLine("Result: " + result);
                    break;

                default:
                    Console.WriteLine("ERROR!");
                    break;
            }








            //Task 2  “AverageNumber”

            double num1;
            double num2;
            double num3;
            double num4;
            bool validation1;


            Console.WriteLine("Enter 4 numbers and get average");

            do
            {
                Console.WriteLine("Enter the First number:");
                validation1 = double.TryParse(Console.ReadLine(), out num1);
                if (!validation1) Console.WriteLine("Please enter numbers only!");
                else break;

            } while (true);

            do
            {
                Console.WriteLine("Enter the Second number:");
                validation1 = double.TryParse(Console.ReadLine(), out num2);
                if (!validation1) Console.WriteLine("Please enter numbers only!");
                else break;
            } while (true);

            do
            {
                Console.WriteLine("Enter the Third number:");
                validation1 = double.TryParse(Console.ReadLine(), out num3);
                if (!validation1) Console.WriteLine("Please enter numbers only!");
                else break;
            } while (true);

            do
            {
                Console.WriteLine("Enter the Fourth number:");
                validation1 = double.TryParse(Console.ReadLine(), out num4);
                if (!validation1) Console.WriteLine("Please enter numbers only!");
                else break;
            } while (true);

            double sum = num1 + num2 + num3 + num4;
            double average = sum / 4;

            Console.WriteLine("The average of " + num1 + " " + num2 + " " + num3 + " " + "and " + num4 + " is " + (average));










            //Task 3  “SwapNumbers"

        int number1;
        int number2;
        int number;
        bool text;

        Console.WriteLine("Swapping numbers");

            do
            {
                Console.WriteLine("First Number Input");
                text = int.TryParse(Console.ReadLine(), out number1);
                if (!text) Console.WriteLine("Please enter numbers only!");
                else break;

            } while (true);


            do
            {
                Console.WriteLine("Second Number Input");
                text = int.TryParse(Console.ReadLine(), out number2);
                if (!text) Console.WriteLine("Please enter numbers only!");
                else break;
            } while (true);
           


            number = number1;
            number1 = number2;
            number2 = number;


            Console.WriteLine("After Swapping");
            Console.WriteLine("First Number: " + number1);
            Console.WriteLine("Second Number: " + number2);

            


  



        Console.ReadLine();
    }

}
}
    