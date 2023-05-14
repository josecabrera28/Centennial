using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal static class Store
    {
        //Attributes
        private static  List<StorePerson> people;

        //Constructor
        static Store()
        {
            people = new List<StorePerson>();
            people.Add(new Employee("jose", "6472987289", 2500.0));
            people.Add(new Employee("John", "3516235897", 2500.0));
            people.Add(new Employee("Merry", "6513286547", 2500.0));
            people.Add(new Employee("George", "6985231456", 2500.0));
            people.Add(new Employee("Kassie", "1452789321", 2500.0));
            people.Add(new Customer("Anna", "3125698523",500.0));
            people.Add(new Customer("Alvaro", "3125698523", 500.0));
            people.Add(new Customer("Carlos", "3125698523", 500.0));
            people.Add(new Customer("Tim", "3125698523", 500.0));
            people.Add(new Customer("koji", "3125698523", 500.0));

        }

        //Methods

        public static void Show()
        {
            foreach(StorePerson person in people)
            {
                Console.WriteLine(person);
            }
            
        }

        public static void Show(string name)
        {
            foreach (StorePerson person in people)
            {
                if (person.Name == name)
                {
                    Console.WriteLine(person);
                }

            }
        }
    }
}
