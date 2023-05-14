using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre
{
    public class Movie
    {

        [Flags]
        public enum GenreEnum
        {
            Unrated = 0,
            Action = 1,
            Comedy = 2,
            Horror = 4,
            Fantasy = 8,
            Musical = 16,
            Mystery = 32,
            Romance = 64,
            Adventure = 128,
            Animation = 256,
            Documentary = 512,

        }


        public int Length { get; }
        public int Year { get; }
        public string Title { get; }
        public GenreEnum Genre { get; private set; }
        public List<string> Cast { get; private set; }

        public Movie(string title, int year, int length)
        {
            this.Title = title;
            this.Year = year;
            this.Length = length;
            Cast = new List<string>();
        }

        public void AddActor(string actor)
        {
            Cast.Add(actor);
        }

        public void SetGenre(GenreEnum genre)
        {
            Genre = genre;
        }
    }
}
