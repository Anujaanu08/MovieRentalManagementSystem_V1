using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem_V1
{
    internal class Movie
    {
        public string movieId;
        public string title;
        public string director;
        public string rentalPrice;

        public Movie(string movieId, string title, string director, string rentalPrice)
        {
            this.movieId = movieId;
            this.title = title;
            this.director = director;
            this.rentalPrice = rentalPrice;
        }

        public override string ToString()
        {
            return $"movieIdId: {movieId}, title: {title}, director: {director}, rentalPrice: {rentalPrice}";
        }

        public virtual string DisplayMovieInfo()
        {
            return ToString();
        }

    }
}
