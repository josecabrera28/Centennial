using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Diamond : Rectangle
    {
        //Attributes
        public override double Area { get { return (base.Area) * 0.5; } }

        //Constructor
        public Diamond (string name, double height, double width)
            : base (name, height, width)
        {

        }
    }
}
