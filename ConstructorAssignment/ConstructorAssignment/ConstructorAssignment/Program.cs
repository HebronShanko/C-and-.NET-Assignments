using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string TheaterName = "Welcome to AMC Theater!";
            Console.WriteLine(TheaterName + " Pick a Movie? ");
            string userMovie = Console.ReadLine();
            var movie = new Construct(userMovie);

            Console.WriteLine("Your movie {0} has the ID of {1}", userMovie, movie.movieID);

            Console.ReadLine();
        }
    }
}
