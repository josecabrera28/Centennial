using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Room
    {
        private int beds=1;
    }

    class House
    {
        private Room room;                 //a room only exist in a house
        public House() { room = new Room(); }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            House address = new House();
            Console.WriteLine(address.ToString());
        }
    }
}
