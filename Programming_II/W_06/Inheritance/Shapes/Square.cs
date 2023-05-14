using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Square : Shape
    {
        //Attributes
        public double Length { get;protected set; }
        public override double Area { get { return Length * Length; } }  

        //Constructor
        public Square (string name, double length)
            : base (name)
        {
            Length= length;
        }
    }
}
