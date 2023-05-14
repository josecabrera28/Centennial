using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal abstract class  Shape
    {
        //Atributes
        public string Name { get;protected set; }
        public abstract double Area { get;}

        //Constructor
        public Shape (string name)
        {
            Name = name;
        }

        //Methods
        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Area: {Area:N}\n";
        }

    }
}
