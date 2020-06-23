using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MovieStoreApp.Domain.ENUM;
using MovieStoreApp.Domain.MovieStore.Member;

namespace MovieStoreApp.Services
{
    public class MovieService
    {
        public Movie[] Movies { get; set; }
        private HelperService helperService = new HelperService();
        Movie[] AvailableMovies = new Movie[0];

        public MovieService()
        {
            Movies = new Movie[]
            {
                new Movie()
                {
                    Title = "The Prestige",
                    Description = "After a tragic accident, two stage magicians engage in a battle to create the ultimate illusion while sacrificing everything they have to outwit each other.",
                    Year = 2006,
                    Genres = Genre.Drama,
                    IsRented = true
                },
                new Movie()
                {
                    Title = "Blow",
                    Description = "The story of how George Jung, along with the Medellín Cartel headed by Pablo Escobar, established the American cocaine market in the 1970s in the United States.",
                    Year = 2001,
                    Genres = Genre.Biography,
                    IsRented = true
                },
                new Movie()
                {
                    Title = "Heat",
                    Description = "A group of professional bank robbers start to feel the heat from police when they unknowingly leave a clue at their latest heist.",
                    Year = 1995,
                    Genres = Genre.Action,
                    IsRented = true
                },
                new Movie()
                {
                    Title = "Casino",
                    Description = "An undercover cop and a mole in the police attempt to identify each other while infiltrating an Irish gang in South Boston.",
                    Year = 1995,
                    Genres = Genre.Crime,
                    IsRented = true
                },
                new Movie()
                {
                    Title = "Raging Bull",
                    Description = "The life of boxer Jake LaMotta, whose violence and temper that led him to the top in the ring destroyed his life outside of it.",
                    Year = 1980,
                    Genres = Genre.Biography,
                    IsRented = false
                },               
                new Movie()
                {
                    Title = "Extraction",
                    Description = "Tyler Rake, a fearless black market mercenary, embarks on the most deadly extraction of his career when he's enlisted to rescue the kidnapped son of an imprisoned international crime lord.",
                    Year = 2020,
                    Genres = Genre.Action,
                    IsRented = false
                }
            };
        }


        public void DisplayMovies(ConsoleColor color, ConsoleColor color2)
        {
            foreach (Movie film in Movies)
            {
                Console.ForegroundColor = color2;
                if (film.IsRented == false) Console.WriteLine($"\n Title: {film.Title}* \n Description: {film.Description} \n Genre: {film.Genres}");
                else
                {
                    Console.ResetColor();
                    Console.ForegroundColor = color;
                    Console.WriteLine($"{film.Title}");
                    Console.ResetColor();
                    Console.WriteLine($"Description: {film.Description} \n Genre: {film.Genres}");
                }
            }
           Console.ReadLine();
        }


        public Movie RentedMovies(int movieNum, User user)
        {
            Movie[] movies = user.Movies;
            Array.Resize(ref movies, movies.Length + 1);
            movies[movies.Length - 1] = AvailableMovies[movieNum - 1];
            AvailableMovies[movieNum - 1].IsRented = true;
            user.Movies = movies;
            return user.Movies[user.Movies.Length - 1];
        }




        public void UserMovies(User user)
        {
            foreach (Movie movies in user.Movies)
            {
                Console.WriteLine($"{movies.Title} {movies.Year}");
            }
        }


        public void AllRentedUser(User user)
        {
            foreach (Movie film in user.Movies)
            {
                int movies = Array.IndexOf(user.Movies, film);
                Console.WriteLine($"{movies + 1}. {film.Title}");
                Console.WriteLine("-----------------------------------");
            }
            if (helperService.RunAgain() == true) SelectingMovie(user);
        }


        public void SelectingMovie(User user)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Your Available movies");
                UserMovies(user);
                Console.WriteLine("-------------------------------");
                foreach (Movie film in Movies)
                {
                    if (film.IsRented == true)
                    {
                        Array.Resize(ref AvailableMovies, AvailableMovies.Length + 1);
                        AvailableMovies[AvailableMovies.Length - 1] = film;
                        Console.WriteLine($"Title: {film.Title} \n Description: {film.Description} \n Genre: {film.Genres}");
                    }
                    else if (film.IsRented == false)
                    {
                        Array.Resize(ref AvailableMovies, AvailableMovies.Length + 1);
                        AvailableMovies[AvailableMovies.Length - 1] = film;
                        Console.WriteLine($"Title: {film.Title}* \n Description: {film.Description} \n Genre: {film.Genres}");
                    }
                }
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine($"Please choose a film. Enter a number between 1 and 6");
                int moviesAvailable = helperService.ValidatePositiveNumbers(Console.ReadLine(), AvailableMovies.Length);
                if (moviesAvailable == 1)
                {
                    Console.Clear();
                    Console.WriteLine("List of movies to watch: ");
                    RentedMovies(moviesAvailable, user);
                    UserMovies(user);
                    if (helperService.RunAgain() == false)
                    {
                        Console.Clear();
                        Console.WriteLine("Your watch movie list is: ");
                        UserMovies(user);
                        Console.WriteLine("\n Done. Press any button");
                        break;
                    }
                }
                else if (moviesAvailable == 2)
                {
                    Console.Clear();
                    Console.WriteLine("List of movies to watch: ");
                    RentedMovies(moviesAvailable, user);
                    UserMovies(user);
                    if (helperService.RunAgain() == false)
                    {
                        Console.Clear();
                        Console.WriteLine("Your watch movie list is: ");
                        UserMovies(user);
                        Console.WriteLine("\n Done. Press any button");
                        break;
                    }
                }
                else if (moviesAvailable == 3)
                {
                    Console.Clear();
                    Console.WriteLine("List of movies to watch: ");
                    RentedMovies(moviesAvailable, user);
                    UserMovies(user);
                    if (helperService.RunAgain() == false)
                    {
                        Console.Clear();
                        Console.WriteLine("Your watch movie list is: ");
                        UserMovies(user);
                        Console.WriteLine("\n Done. Press any button");
                        break;
                    }
                }
                else if (moviesAvailable == 4)
                {
                    Console.Clear();
                    Console.WriteLine("List of movies to watch: ");
                    RentedMovies(moviesAvailable, user);
                    UserMovies(user);
                    if (helperService.RunAgain() == false)
                    {
                        Console.Clear();
                        Console.WriteLine("Your watch movie list is: ");
                        UserMovies(user);
                        Console.WriteLine("\n Done. Press any button");
                        break;
                    }
                }
                else if (Movies[moviesAvailable - 1].IsRented == false)
                {
                    Console.Clear();
                    Console.WriteLine("This movie is not available!");
                    if (helperService.RunAgain() == false)
                    {
                        Console.Clear();
                        Console.WriteLine("Your watch movie list is: ");
                        UserMovies(user);
                        Console.WriteLine("\n Done. Press any button");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("List of movies to watch: ");
                    UserMovies(user);
                    Console.WriteLine("Done. Press any button");
                    break;
                }
            }





            Console.ReadLine();
        }
    }
}
