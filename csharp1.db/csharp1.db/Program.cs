using System;

namespace MovieApp.NewDb
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MovieContext())
            {
                Console.WriteLine("enter movie title");
                string title = Console.ReadLine();
                Console.WriteLine("enter movie released year");
                string year = Console.ReadLine();
                Console.WriteLine("enter movie category");
                string category = Console.ReadLine();
                Console.WriteLine("enter movie budget");
                string budget = Console.ReadLine();
                db.Movies.Add(new Movietbl { title = title });
                db.Movies.Add(new Movietbl { year = year });
                db.Movies.Add(new Movietbl { category = category });
                db.Movies.Add(new Movietbl { budget = budget });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var Movietbl in db.Movies)
                {
                    Console.WriteLine(" - {0}", Movietbl.title, Movietbl.year, Movietbl.category, Movietbl.budget);
                }
            }
        }
    }
}
