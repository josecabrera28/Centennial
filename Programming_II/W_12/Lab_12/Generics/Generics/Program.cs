using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<string> node1 = new Node<string>("Mary");
            LinkedList<string> list1 = new LinkedList<string>(node1);
            list1.Add(new Node<string>("had"));
            list1.Add(new Node<string>("a"));
            list1.Add(new Node<string>("little"));
            list1.Add(new Node<string>("lamb"));
            Console.WriteLine(list1);
            Console.WriteLine("");
            Node<char> node2 = new Node<char>('J');
            LinkedList<char> list2 = new LinkedList<char>(node2);
            list2.Add(new Node<char>('O'));
            list2.Add(new Node<char>('S'));
            list2.Add(new Node<char>('E'));
            list2.Add(new Node<char>('.'));
            Console.WriteLine(list2);
            Console.WriteLine("");
            Node<int> node3 = new Node<int>(5);
            LinkedList<int> list3 = new LinkedList<int>(node3);
            list3.Add(new Node<int>(4));
            list3.Add(new Node<int>(3));
            list3.Add(new Node<int>(2));
            list3.Add(new Node<int>(1));
            Console.WriteLine(list3);
        }
    }
}
