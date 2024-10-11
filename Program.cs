using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem_V1
{
    internal class Program
    { 
        static MovieManager movieManager = new MovieManager();
        static int id = 001;
        static void Main(string[] args)
        {
            Movie Movie1 = new Movie("MOVIE_001", "Titanic", "James Cameroon", "1.00");
           Console.WriteLine( Movie1.ToString());
            menu();
           
        }

        static void menu()
        {

            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("Movie Rental Management System:\r\n1. Add a Movie\r\n2. View All Movies\r\n3. Update a Movie\r\n4. Delete a Movie\r\n5. Exit");
                Console.Write("Choose an option: ");

                int opt = int.Parse(Console.ReadLine());
                Console.Clear();
                
                switch (opt)
                {
                    case 1:
                        Console.Write("Enter Movie Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Movie Director: ");
                        string director = Console.ReadLine();
                        Console.Write("Enter Movie rental price: ");
                        string price = Console.ReadLine();
                        movieManager.CreateMovie(new Movie($"Movie_{id}", price, title, director));
                        id++;
                        Console.ReadLine();
                        break;
                    case 2:
                        movieManager.ReadMovies();

                        break;
                    case 3:
                        Console.Write("Enter the movie id to update : ");
                        string movid = Console.ReadLine();
                        Console.Write("Enter Movie Title: ");
                        string newtitle = Console.ReadLine();
                        Console.Write("Enter Movie Director: ");
                        string newdirector = Console.ReadLine();
                        Console.Write("Enter Movie rental price: ");
                        string newprice = Console.ReadLine();
                        movieManager.UpdateMovie(new Movie(movid, newtitle, newdirector, newprice));
                        break;
                    case 4:
                        Console.Write("Enter the movie id to delete : ");
                        string delid = Console.ReadLine();
                        movieManager.DeleteMovie(delid);
                        break;
                    case 5:
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Enter the correct option");
                        break;
                }

            }


        }
    }
}
