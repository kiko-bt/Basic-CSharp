using System;

namespace Homework___Arrays_and_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task 1:


            int even = 0;
            int numbers;
            bool validation;
            int[] array = new int[6];

            Console.WriteLine("Enter six numbers: ");



            for (int i = 0; i < array.Length; i++)
            {
                validation = int.TryParse(Console.ReadLine(), out array[i]);
                if (validation) Console.WriteLine($"Number: {array[i]}");
                else Console.WriteLine("ERROR!");
            }



            for (int i = 0; i < array.Length; i++)
            {
                numbers = array[i];

                if (numbers % 2 == 0)
                {
                    even += array[i];
                }

            }


            Console.WriteLine($"The result is: {even}");










            //Task 2

            string[] studentsG1 = { "Kiko", "Beko", "Martin", "Sara", "Darija" };
            string[] studentsG2 = { "Simona", "Mara", "Petar", "Zika", "Marija" };

            Console.WriteLine("Enter student group: (there are 1 and 2)");


            int number;

            do
            {
                number = int.Parse(Console.ReadLine());
                Console.WriteLine($"You entered: {number}");
                if (number != 1 && number != 2) Console.WriteLine("ERROR! Wrong Number, please try again");
                else break;
            } while (true);


            for (int i = 0; i < studentsG1.Length; i++)
            {
                if (number == 1) Console.WriteLine(studentsG1[i]);
                else break;
            }


            for (int i = 0; i < studentsG2.Length; i++)
            {
                if (number == 2) Console.WriteLine(studentsG2[i]);
                else break;
            }









            //Task 3

            Console.WriteLine("If you are a student or trainer from SEDC, please fill in the text field");

            string studentTrainer;
            string separator = new string('-', 30);

            do
            {
                studentTrainer = Console.ReadLine();
                if (studentTrainer != "trainer" && studentTrainer != "student") Console.WriteLine("Enter student or trainer!");
                else break;
            } while (true);



            string[] students = {"G1: \n" + "Hristijan", "Stefan", "Petar", "Nikola", "Angela", "Nate", "Aleksandar \n",
                                 "G2: \n" + "Mitko", "Trajko", "Stanko", "Peco", "Anastasija", "Marija", "Darija \n",
                                 "G3: \n" + "Stevce", "Darko", "Zarko", "Marko", "Elena", "Antonio \n" };

            string[] subjects = { "c#", "Java Script", "Angular", "Python", "PHP", "Node Js" };

            string[] trainers = { "Martin", "Ivo", "Dejan", "Krsto", "Nikola" };

            string[] newAnnouncement = { "New homeworks for c# today", "JavaScript exam at April" };



            Console.WriteLine("Enter your name: ");
            string name;

            do
            {
                name = Console.ReadLine();
                if (name == "") Console.WriteLine("Enter your name: ");
                else if (name.Length == 1) Console.WriteLine("Use longer text into the text area. Try Again");
                else break;
            } while (true);




            if (studentTrainer == "trainer")
            {
                int val1 = Array.IndexOf(students, name);
                if (val1 != -1)
                {
                    Console.WriteLine("ERROR!");
                }
                else
                {
                    Console.WriteLine(separator);
                    foreach (var student in students)
                    {
                        Console.WriteLine(student + " ");
                    }
                    Array.Resize(ref newAnnouncement, newAnnouncement.Length + 1);
                    int count = 0;
                    Console.WriteLine("Enter new Announcement: ");
                    string announcement = Console.ReadLine();
                    newAnnouncement[count] = announcement;
                    if (announcement == "")
                    {
                        Console.WriteLine("You don't add new  Announcement. Try Again");
                    }
                    else if (announcement.Length == 1)
                    {
                        Console.WriteLine("Use longer text into the text area. Try Again");
                    }
                    else
                    {
                        Console.WriteLine($"New Announcement is added successfully: {announcement}");
                        Console.WriteLine(separator);
                        foreach (var item in newAnnouncement)
                        {
                            int val2 = Array.IndexOf(newAnnouncement, announcement);
                            Console.WriteLine($"{val2 + 1}. {item}");
                        }
                    }

                }
            }




            if (studentTrainer == "student")
            {
                int val = Array.IndexOf(subjects, name);
                if (val != -1)
                {
                    Console.WriteLine("ERROR!");
                }
                else
                {
                    foreach (var subject in subjects)
                    {
                        Console.WriteLine(subject + " ");
                    }
                    Console.WriteLine(separator);
                    foreach (var item in newAnnouncement)
                    {
                        int val3 = Array.IndexOf(newAnnouncement, item);
                        Console.WriteLine($" {val3 + 1}. List of new Announcements : {item}");
                    }
                }
            }






            Console.ReadLine();

        }
    }
}
