using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreApp.Domain.MovieStore.Member;
using MovieStoreApp.Domain.ENUM;
using System.Linq;

namespace MovieStoreApp.Services
{
    public class UserService
    {
        public User[] Users { get; set; }
        private HelperService helperService = new HelperService();

        public UserService()
        {
            Users = new User[]
            {
                new User()
                {
                    FirstName = "Stefan",
                    LastName = "Lukovski",
                    Age = 21,
                    UserName = "Stef4e123",
                    Password = "noway",
                    PhoneNumber = 047 - 256 - 654,
                    Movies = new Movie[]
                    {
                        new Movie()
                        {
                            Title = "The Departed",
                            Description = "An undercover cop and a mole in the police attempt to identify each other while infiltrating an Irish gang in South Boston.",
                            Year = 2016,
                            Genres = Genre.Action
                        }
                    },
                    DateOfRegistration = new DateTime(2019, 07, 25),
                    ExpireDate = new DateTime(2020, 01, 25),
                    TypeOfSubscription = TypeOfSubscription.Monthly
                },
                new User()
                {
                    FirstName = "Marija",
                    LastName = "Trenkovska",
                    Age = 28,
                    UserName = "Macaaaaa",
                    Password = "mackagolema",
                    PhoneNumber = 047 - 258 - 822,
                    Movies = new Movie[]
                    {
                        new Movie()
                        {
                            Title = "Thelma&Luis",
                            Description = "It stars Geena Davis as Thelma and Susan Sarandon as Louise, two friends who embark on a road trip which ends up in unforeseen circumstances. The supporting cast include Harvey Keitel, Michael Madsen, and Brad Pitt in one of his first major film roles.",
                            Year = 1991,
                            Genres = Genre.Adventure
                        }
                    },
                    DateOfRegistration = new DateTime(2019, 02, 23),
                    ExpireDate = new DateTime(2021, 02, 23),
                    TypeOfSubscription = TypeOfSubscription.Annually
                },
                 new User()
                {
                    FirstName = "Arijan",
                    LastName = "Shabani",
                    Age = 19,
                    UserName = "Arijan4e01",
                    Password = "Macedonia",
                    PhoneNumber = 047 - 221 - 614,
                    Movies = new Movie[]
                    {
                        new Movie()
                        {
                            Title = "Rambo",
                            Description = "Rambo must confront his past and unearth his ruthless combat skills to exact revenge in a final mission.",
                            Year = 2000,
                            Genres = Genre.Biography
                        }
                    },
                    DateOfRegistration = new DateTime(2018, 07, 25),
                    ExpireDate = new DateTime(2021, 07, 25),
                    TypeOfSubscription = TypeOfSubscription.Annually
                },
            };
        }


        public User LogIn(string username, string password)
        {
            foreach (User user in Users)
            {
                if (user.UserName == username && user.Password == password)
                    return user;
            }
            return null;
        }


        public void DisplayUsers()
        {
            foreach (User user in Users)
            {
                Console.WriteLine($"{user.FirstName} {user.LastName} {user.DateOfRegistration}");
            }
        }

        
        public User AddMember(User user)
        {
            User[] newMember = Users;
            Array.Resize(ref newMember, newMember.Length + 1);
            newMember[newMember.Length - 1] = user;
            Users = newMember;

      
            return Users[Users.Length - 1];
        }


        public void DeleteMember(ConsoleColor color)
        {
            DisplayUsers();
            Console.Write($"Which member do you want to remove of {Users.Length} members: ");
            int chosenMember = helperService.ValidatePositiveNumbers(Console.ReadLine(), Users.Length);
            Users = Users.Where((source, index) => index != chosenMember - 1).ToArray();

            Console.Clear();

            Console.WriteLine($"Now remained this members: ");
            Console.ForegroundColor = color;
            DisplayUsers();
        }


        public void UserName(string firstName, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"Welcome {firstName}");
            Console.ResetColor();

            Console.WriteLine("1. Check your subscription type and expiration of membership  \n 2. Select a movie \n 3. See all your rented movies");
        }
     
    }
}
