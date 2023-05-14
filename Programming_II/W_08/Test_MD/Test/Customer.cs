using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Customer : StorePerson
    {
        //Attributes
        public double Credit { get; }

        //Constructor
        public Customer (string name, string cell, double credit = 500.0)
            : base(name,cell)
        {
            Credit= credit;
        }

        //Methods
        public override string ToString()
        {
            return $"Id: {base.Id}\n" +
                $"Name: {base.Name}\n" +
                $"Cell: {base.Cell}\n" +
                $"Credit: {Credit}\n";
        }
    }
}
