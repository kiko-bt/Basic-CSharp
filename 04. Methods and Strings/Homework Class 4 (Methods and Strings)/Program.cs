using System;


namespace Homework_Class_4__Methods_and_Strings_
{
    class Program
    {
        

        //Task1
        static void Substring()
        {
            string text = "Hello from SEDC Codecademy v7.0";

            Console.WriteLine("Enter a number: ");

            bool validation = int.TryParse(Console.ReadLine(), out int number);

            while (!validation)
            {
                Console.WriteLine("Enter a number: ");
                validation = int.TryParse(Console.ReadLine(), out number);
            }

            if (number > text.Length)
            {
                Console.WriteLine($"The maximum numbers of character is {text.Length}. Try again...");
            }
            else
            {
                string firstN = text.Substring(0, number);

                Console.WriteLine($"You write {number} and you get '{firstN}' of the given string.");

                Console.WriteLine("The length of the new string is: " + firstN.Length);
                Console.WriteLine($"And left {text.Length - firstN.Length} numbers of characters.");
            }
            Console.ReadLine();
        }





        //Task 3
        static int ageCalculator(DateTime birthdayDate)
        {
            DateTime birthday = DateTime.Today;
            int age = birthday.Year - birthdayDate.Year;
            return age;
        }







        static void Main(string[] args)
        {
            Console.Title = "DOMINATOR";


            Substring();


            #region AgeCalculator Task3

            Console.WriteLine("Enter your birthday: ");
            bool validation = DateTime.TryParse(Console.ReadLine(), out DateTime day);

            while (!validation || day > DateTime.Now)
            {
                Console.WriteLine("Invalid Input! Try again...");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Enter your birthday: ");
                validation = DateTime.TryParse(Console.ReadLine(), out day);
            }


            Console.WriteLine($"You are {ageCalculator(day)} years old.");

            #endregion





            #region DateTime Task2

            //Print the date that is 3 days from Now
            var days3 = DateTime.Now;
            Console.WriteLine($"3 days from now will be: {days3.AddDays(3)}");



            //Print the date that is one month from Now
            var oneMonth = DateTime.Now;
            Console.WriteLine($"One month from Now will be: {oneMonth.AddDays(30)}");



            //Print the date that is one month and 3 days from now
            var month3days = DateTime.Now;
            Console.WriteLine($"One month and three days from now {month3days.AddDays(33)}");


            //Print 1 year and 2 months ago from today
            DateTime yearAnd2Months = DateTime.Today;
            Console.WriteLine($"One year and two months from today {yearAnd2Months.AddYears(1).AddMonths(2)}");


            //Print only the current month of today
            string currentMonth = "31.03.2020";
            Console.WriteLine($"Current month of today: {DateTime.Parse(currentMonth)}");


            //Print only the current year of today
            string currentYear = DateTime.Now.Year.ToString();
            Console.WriteLine(currentYear);

            #endregion



         
            Console.ReadLine();
        }
    }
}
