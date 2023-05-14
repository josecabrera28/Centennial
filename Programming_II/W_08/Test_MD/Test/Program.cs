using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Showing all the people
            Console.WriteLine($"\n\nAll people");
            Store.Show();
            //Showing a person with matching name
            string name = "Kassie";
            Console.WriteLine($"\nPerson with name {name}:");
            Store.Show(name);
        }
    }
}
