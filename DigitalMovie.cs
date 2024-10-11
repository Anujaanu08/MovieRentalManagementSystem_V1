using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem_V1
{
    internal class DigitalMovie : Movie
    {
        public DigitalMovie(string movieId, string title, string director, string rentalPrice) : base(movieId, title, director, rentalPrice)
        {
        }

        public string Duration;
        public string DiscWeight;

        public override string DisplayMovieInfo()
        {
            return $"{base.ToString()} Duration{Duration} DiscWeight{DiscWeight}";
        }
    }
}
