using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : Shape
    {
        //Atributes
        public double Width { get; protected set; }
        public double Height { get; protected set; }
        public override double Area { get { return Width * Height; } }

        //Constructor
        public Rectangle(string name, double length, double width)
            : base(name)
        {
            Width= width;
            Height= length;
        }

    }
}
