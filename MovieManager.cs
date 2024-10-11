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
        }

        public void ReadMovies()
        {
            foreach (var movie in movies)
            {
                Console.WriteLine(movie.ToString());
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
            }
            else
            {
                Console.WriteLine("Invalid id");
            }
        }

        public void DeleteMovie(string id) {
            var mov = movies.Find(x => x.movieId == id);
            if (mov != null)
            {
               movies.Remove(mov);
            }
            else
            {
                Console.WriteLine("Invalid id");
            }
        }

    }
}
