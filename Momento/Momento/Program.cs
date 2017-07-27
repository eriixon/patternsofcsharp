using System;

namespace Momento
{
    class Program
    {
        static void Main(string[] args)
        {
            var movieDb = new MovieDB();
            var movie = new Movie() { Name = "The Big Lebowki", Length = 10 };

            movie.Play();
            Console.WriteLine("Press enter for continue..");
            Console.Read();

            movie.Stop();
            movieDb.AddMovie(movie.GetState());
            Console.WriteLine("Press enter for continue..");
            Console.Read();

            movie = new Movie();
            movie.SetState(movieDb.GetMovie("The Big Lebowki"));
            movie.Play();
            Console.Read();
        }
    }
}
