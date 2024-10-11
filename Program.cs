using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie Movie1 = new Movie("MOVIE_001", "Titanic", "James Cameroon", "1.00");
           Console.WriteLine( Movie1.ToString());
            Console.ReadLine();
        }
    }
}
