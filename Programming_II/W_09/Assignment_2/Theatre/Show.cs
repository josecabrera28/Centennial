using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre
{
    public class Show
    {

        public enum DayEnum
        {
            Sun,
            Mon,
            Tue,
            Wed,
            Thu,
            Fri,
            Sat

        }

        public double Price { get; }
        public DayEnum Day { get; }
        public Movie Movie { get; }
        public Time Time { get; }

        public Show(Movie movie, Time time, DayEnum day, double price)
        {
            Movie = movie;
            Time = time;
            Day = day;
            Price = price;
        }
        public override string ToString()
        {
            return string.Join(", ", Movie.Cast);
        }
    }
}
