using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Even after the person object is destroyed, the address object will still be alive.
Loosely coupled!!!
*/
namespace Aggregation
{
    class Address
    {
        public string stName;
    }

    class Person
    {
        private Address address;
        public Person(Address address) { this.address = address; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            Person person = new Person(address);
        }
    }
}
