using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem_V1
{
    internal class MovieManager 
    {
        List<Movie> movies = new List<Movie>();
      
        public void CreateMovie(Movie movie)
        {
            movies.Add(movie);
            Console.WriteLine("Movie Added successfully");
        }

        public void ReadMovies()
        {
            if (movies.Count > 0)
            {
                foreach (var movie in movies)
                {
                    Console.WriteLine(movie.ToString());
                }
            }
            else
            {
                Console.WriteLine("No movies found ");
            }
            Console.ReadLine();
        }

        public void UpdateMovie(Movie movie)
        {
            var mov = movies.Find(x=>x.movieId==movie.movieId);
            if (mov != null) {
                mov.title = movie.title;
                mov.rentalPrice = movie.rentalPrice;
                mov.director = movie.director;
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

    }
}
