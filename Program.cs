using Microsoft.SqlServer.Server;
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
            
            //var mo = new DVDMovie("MOVIE_001", "Titanic", "James Cameroon", "1.00")
            //{
            //    Format= "hhh",
            //    FileSize = "ss"
            //};
          // Console.WriteLine( mo.DisplayMovieInfo());
            //Movie Movie1 = new Movie("MOVIE_001", "Titanic", "James Cameroon", "1.00");
           // Console.WriteLine(Movie1.DisplayMovieInfo());
            //Console.ReadLine();
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
                        Console.Write("Enter Movie type (1 : DVDMovie , 2 : Digitalmovie): ");
                        string type = Console.ReadLine();
                        if(type == "1")
                        {
                            Console.Write("Enter Movie FileSize: ");
                            string filesize  = Console.ReadLine();
                            Console.Write("Enter Movie format: ");
                            string format = Console.ReadLine();
                            movieManager.CreateMovie(new DVDMovie($"Movie_{id}", price, title, director)
                            {
                                Format = filesize,
                                FileSize = format
                            });
                            id++;
                        }
                        else if(type == "2")
                        {
                            Console.Write("Enter Movie Duration: ");
                            string Duration = Console.ReadLine();
                            Console.Write("Enter Movie DiscWeight: ");
                            string DiscWeight = Console.ReadLine();
                            movieManager.CreateMovie(new DigitalMovie($"Movie_{id}", price, title, director)
                            {
                                DiscWeight = DiscWeight,
                                Duration = Duration
                            });
                            id++;
                        }
                        else
                        {
                            Console.WriteLine("invalid option");
                        }
                     
                        Console.ReadLine();
                        break;
                    case 2:
                        movieManager.ReadMovies();

                        break;
                    case 3:
                        Console.Write("Enter the movie id to update : ");
                        string movid = Console.ReadLine();
                        movieManager.UpdateMovie(movid);
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
