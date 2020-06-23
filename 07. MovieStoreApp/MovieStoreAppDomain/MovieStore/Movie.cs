using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreApp.Domain.ENUM;

namespace MovieStoreApp.Domain.MovieStore.Member
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public Genre Genres { get; set; }
        private int Price { get; set; }
        public bool IsRented { get; set; }

        public void SetPrice()
        {
            if (Year < 2000)
            {
                Random random = new Random(Price);
                random.Next(100, 200);
                Console.WriteLine(random);
            }
            else if (Year > 2000 && Year <= 2010)
            {
                Random random = new Random(Price);
                random.Next(200, 300);
                Console.WriteLine(random);
            }
            else if (Year < 2010)
            {
                Random random = new Random(Price);
                random.Next(300, 500);
                Console.WriteLine(random);
            }

        }

        public Movie(string title, string description, int year, Genre genres, bool isRented)
        {
            Title = title;
            Description = description;
            Year = year;
            Genres = genres;
            IsRented = isRented;
        }

        public Movie()
        {

        }
    }
}
