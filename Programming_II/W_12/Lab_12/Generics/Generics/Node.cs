using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Node <T>
    {
        //Atributes
        public T Data { get; }
        public Node <T> Next {get; set;}

        //Constructor
        public Node (T data)
        {
            Data = data;

        }

        //Methods
        public override string ToString()
        {
            return $"Data: {Data}";
        }

    }
}
