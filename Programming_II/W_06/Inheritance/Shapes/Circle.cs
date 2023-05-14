using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle : Square
    {
        //Attributes
        public override double Area { get { return (base.Area)*Math.PI; } }

        //Constructor
        public Circle (string name, double length)
            : base (name, length)
        {

        }
    }
}
