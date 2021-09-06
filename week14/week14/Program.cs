using System;

namespace week14
{
    class Program
    {
        struct MovieInfo
        {
            public string Name;
            public string Genre;
            public int Minute;
        }
        static void Main(string[] args)
        {
            MovieInfo myMovie;
            //myMovie.Name = Console.ReadLine();
            //myMovie.Genre = Console.ReadLine();
            //myMovie.Minute = int.Parse(Console.ReadLine());
            myMovie = Readinfo();
            Showinfo(myMovie);
            //Console.WriteLine("Movie name : {0}", myMovie.Name);
            //Console.WriteLine("Movie genre : {0}", myMovie.Genre);
            //Console.WriteLine("Movie minute : {0}", myMovie.Minute);
        }
        static MovieInfo Readinfo()
        {
            MovieInfo input;
            input.Name = Console.ReadLine();
            input.Genre = Console.ReadLine();
            input.Minute = int.Parse(Console.ReadLine());
            return input;
        }
        static void Showinfo(MovieInfo read)
        {
            Console.WriteLine("Movie name : {0}", read.Name);
            Console.WriteLine("Movie genre : {0}", read.Genre);
            Console.WriteLine("Movie minute : {0}", read.Minute);
        }
    }
}
