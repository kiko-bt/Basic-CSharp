using MovieStoreApp.Domain.MovieStore.Member;
using MovieStoreApp.Domain.ENUM;
using MovieStoreApp.Domain.Employee;
using MovieStoreApp.Services;
using System;

namespace MovieStoreApp_Pt1
{
    class Program
    {

        private static UserService _userService = new UserService();
        private static EmployeeService _employeeService = new EmployeeService();
        private static MovieService _movieService = new MovieService();
        private static HelperService _helperService = new HelperService();
        private static User _loggedUser = null;
        private static Employee EmployeeLogIn = null;
        private static User UserLogIn = null;



        static void Main(string[] args)
        {
            Console.WriteLine("Welcome People");
         


            while (true)
            {
                Console.WriteLine("To Log In Enter 1 for Employee, Enter 2 for User please");
                int login = _helperService.ValidatePositiveNumbers(Console.ReadLine(), 2);

                if (login == 1)
                {
                    Console.WriteLine("Enter Username");
                    string user = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Enter Password");
                    string password = Console.ReadLine();
                    Console.Clear();
                    EmployeeLogIn = _employeeService.Login(user, password);
                    if (EmployeeLogIn == null)
                    {
                        _helperService.Error("Wrong username or password!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (login == 1)
                    {
                        _employeeService.EmployeeName();
                    }
                    else
                    {
                        break;
                    }





                    Console.WriteLine("----------------------------------------");


                    while (true)
                    {
                        int employeeNum = _helperService.ValidatePositiveNumbers(Console.ReadLine(), 4);

                        switch (employeeNum)
                        {
                            case 1:
                                Console.Clear();
                                _userService.DisplayUsers();
                                return;

                            case 2:
                                Console.Clear();
                                _movieService.DisplayMovies(ConsoleColor.Yellow, ConsoleColor.Red);
                                return;

                            case 3:
                                Console.WriteLine("Enter your first name");
                                string firstName = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Enter your last name");
                                string lastName = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Enter username");
                                string username = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Enter password");
                                string passWord = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Enter your age");
                                int age = _helperService.ValidatePositiveNumbers(Console.ReadLine(), 99);
                                Console.Clear();
                                Console.WriteLine("Enter your phone number");
                                int phoneNumber = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Type Of Subsciption \n 1.Annual \n 2.Monthly");
                                int subscription = _helperService.ValidatePositiveNumbers(Console.ReadLine(), 2);

                                User newUser = new User(firstName, lastName, age, username, passWord, phoneNumber);
                                _loggedUser = _userService.AddMember(newUser);

                                if (_loggedUser == null)
                                {
                                    _helperService.Error("Register not successfully!");
                                }
                                else
                                {
                                    Console.Clear();
                                    _userService.DisplayUsers();
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                break;

                            case 4:
                                _userService.DeleteMember(ConsoleColor.Red);
                                Console.ResetColor();
                                break;
                            default:
                                Console.WriteLine("Unrecognized option. Please choose from 1 to 4!");
                                Console.Clear();
                                break;
                        }
                        break;
                    }
                }

                else if (login == 2)
                {

                    Console.WriteLine("Enter Username:");
                    string userUserName = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Enter Password:");
                    string userPassword = Console.ReadLine();
                    Console.Clear();
                    UserLogIn = _userService.LogIn(userUserName, userPassword);
                    if (UserLogIn == null)
                    {
                        _helperService.Error("Wrong username or password!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (login == 2)
                    {
                        Console.Clear();
                        _userService.UserName(userUserName, ConsoleColor.Green);
                    }
                    else
                    {
                        break;
                    }






                    while (true)
                    {
                        int userNum = _helperService.ValidatePositiveNumbers(Console.ReadLine(), 4);
                        switch (userNum)
                        {
                            case 1:
                                Console.Clear();
                                UserLogIn.SetExpires();
                                return;
                            case 2:
                                Console.Clear();
                                _movieService.SelectingMovie(UserLogIn);
                                break;
                            case 3:
                                Console.Clear();
                                _movieService.AllRentedUser(UserLogIn);
                                return;
                            default:
                                Console.WriteLine("Unrecognized option. Please choose from 1 to 4!");
                                Console.Clear();
                                break;
                        }
                        break;
                    }
                }
            }







        



                Console.ReadLine();
        }
    }
}
