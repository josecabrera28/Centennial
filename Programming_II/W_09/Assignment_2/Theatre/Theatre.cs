using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre
{
    internal class Theatre
    {
        public List<Show> Shows;

        public string Name { get; }

        public Theatre(string name)
        {
            Name = name;
            Shows = new List<Show>();
        }

        //+	AddShow(show : Show)               : void
        public void AddShow(Show show)
        {
            Shows.Add(show);
        }
        //+	PrintShows() : void
        public void PrintShows()
        {
            Console.WriteLine("METHOD PRINTSHOWS BY NO FILTER");
            foreach (Show show in Shows)
            {
                int counter = 1;
                Console.WriteLine($"Theatre name: {Name}\n" +
                $"Filtered by: A11 Shows" +
                $"{counter}: {show}");
                counter++;
            }
            Console.WriteLine("");
        }

        //+	PrintShows(time : Time)            : void
        public void PrintShows(Time time)
        {
            Console.WriteLine("METHOD PRINTSHOWS BY TIME FILTER");
            int counter = 1;
            foreach (Show show in Shows)
            {
                if (show.Time == time)
                {
                    Console.WriteLine($"{counter} - Theatre name: {Name}\n" +
                        $"Filtered by time: {time}\n" +
                        $"{show}\n");
                        counter++;
                }
            }
            Console.WriteLine("");
        }
        //+	PrintShows(actor : string)          : void

        public void PrintShows(string actor)
        {
            Console.WriteLine("METHOD PRINTSHOWS BY ACTOR FILTER");
            int counter = 1;
            foreach (Show show in Shows)
            {
                if (show.Movie.Cast.Contains(actor)==true)
                {
                    Console.WriteLine($"{counter} - Theatre name: {Name}\n" +
                        $"Filtered by actor: {actor}\n" +
                        $"{show}\n");
                        counter++;
                }
            }
            Console.WriteLine("");
        }
        //+	PrintShows(day : Day, time : Time) : void

    }
}
