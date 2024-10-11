using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem_V1
{
    internal class MovieManager 
    {
        List<Movie> movies = new List<Movie>();
      
        public void CreateMovie(Movie movie)
        {
           // movie.rentalPrice = ValidateMovieRentalPrice(movie.rentalPrice);
            movies.Add(movie);
            Console.WriteLine("Movie Added successfully");
        }

        public void ReadMovies()
        {
            if (movies.Count > 0)
            {
                foreach (var movie in movies)
                {
                    Console.WriteLine(movie.DisplayMovieInfo());
                }
            }
            else
            {
                Console.WriteLine("No movies found ");
            }
            Console.ReadLine();
        }

        public void UpdateMovie(string id)
        {
            var mov = movies.Find(x=>x.movieId==id);
            if (mov != null) {
                Console.Write("Enter Movie Title: ");
                string newtitle = Console.ReadLine();
                Console.Write("Enter Movie Director: ");
                string newdirector = Console.ReadLine();
                Console.Write("Enter Movie rental price: ");
                string newprice =Console.ReadLine();
                mov.title = newtitle;
                mov.rentalPrice = newprice;
                mov.director = newdirector;

                Console.WriteLine("Movie updated successfully");
            }
            else
            {
                Console.WriteLine("Invalid id");
            }
            Console.ReadLine();
        }

        public void DeleteMovie(string id) {
            var mov = movies.Find(x => x.movieId == id);
            if (mov != null)
            {
               movies.Remove(mov);
                Console.WriteLine("Movie deleted successfully");
            }
            else
            {
                Console.WriteLine("Invalid id");
            }
            Console.ReadLine ();
        }


        public int ValidateMovieRentalPrice(int pri) 
        {
          
            while (pri <= 0) 
            {
            Console.Write("Enter a positive price : ");
                pri = int.Parse(Console.ReadLine());   
            }
            return pri;
        }
    }
}
