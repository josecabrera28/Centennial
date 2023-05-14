using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre
{
    public class Time
    {
        //Attributes
        public int Hours { get; }
        public int Minutes { get; }

        //Constructor
        public Time(int hours, int minutes = 0)
        {
            Hours = hours;
            Minutes = minutes;
        }

        //Methods
        public override string ToString()
        {
            return $"TIME \n" +
                $"Hour: {Hours} \t" +
                $"Minute: {Minutes} \n";
        }

        public static bool operator == (Time lhs, Time rhs)
        {
            bool result = false;
            int ticksLhs = (lhs.Hours * 60) + lhs.Minutes;
            int ticksRhs = (rhs.Hours * 60) + rhs.Minutes;
            if ((Math.Abs(ticksLhs - ticksRhs)) <= 15)
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(Time lhs, Time rhs)
        {
            bool result = false;
            int ticksLhs = (lhs.Hours * 60) + lhs.Minutes;
            int ticksRhs = (rhs.Hours * 60) + rhs.Minutes;
            if ((Math.Abs(ticksLhs - ticksRhs)) >= 15)
            {
                result = true;
            }
            return result;
        }
    }
}
