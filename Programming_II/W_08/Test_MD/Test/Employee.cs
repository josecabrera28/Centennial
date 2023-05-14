using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Employee : StorePerson
    {
        //attributes
        public double Salary { get;  }

        //constructor
        public Employee(string name, string cell, double salary = 2500.0) 
            : base (name,cell)
        
        {
            Salary= salary;
        }

        //methods
        public override string ToString()
        {
            return $"Id: {base.Id}\n" +
                $"Name: {base.Name}\n" +
                $"Cell: {base.Cell}\n"+
                $"Salary: {Salary}\n"; 
        }
    }
}
