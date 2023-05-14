using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Ellipse : Rectangle
    {
        //Attributes
        public override double Area { get { return (base.Area) * Math.PI; } }

        //Constructor
        public Ellipse (string name, double height, double width)
            : base (name, height, width)
        {

        }

    }
}
