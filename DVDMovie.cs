using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem_V1
{
    internal class DVDMovie : Movie
    {
        public DVDMovie(string movieId, string title, string director, string rentalPrice) : base(movieId, title, director, rentalPrice)
        {
        }

        public string Format;
        public string FileSize;

        public override string DisplayMovieInfo() 
        {
            return $"{base.ToString()} Format{Format} FileSize{FileSize}";
        }
    }
}
