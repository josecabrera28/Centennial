using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class LinkedList<T>
    {
        //Attributes
        public Node<T> Root { get; }
        public Node<T> Current { get; set; }

        //Constructor
        public LinkedList(Node<T> root) {
            Root = root;
            Current= root;
        }

        public LinkedList(T data) :this (new Node<T>(data)){
            
        }

        //Methods
        public void Add(Node<T> node)
        {
            Current.Next = node;
            Current = node;
        }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            this.Add(node);
        }

        public override string ToString()
        {
            Node<T> test = Root.Next;
            string text = "";

            while (test != null)
            {
                text += "Next: Data: " +Convert.ToString(test.Data) + "\n";
                test = test.Next;
            }
            return $"Root: {Root}\n"+
                $"{text}"+
                $"Current: {Current} \n";
        }
    }
}
