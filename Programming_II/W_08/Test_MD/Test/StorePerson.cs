using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal abstract class StorePerson
    {
        //attributes
        static protected int ID = 100000;
        public string Name { get;  }
        public string Cell { get; }
        public string Id { get; }
        //constructor
        public StorePerson(string name, string cell)
        {
            this.Name = name;
            this.Cell = cell;
            this.Id = Convert.ToString(ID);
            ID++;
        }

        //method
    }
}
