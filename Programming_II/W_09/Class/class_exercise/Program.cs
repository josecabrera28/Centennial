using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_exercise
{
    //POLYMORPHISM
    class DrawingObject
    {
        public virtual void Draw()
        {
            Console.WriteLine("I am a generic object");
        }
    }

    class Line : DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I am a Line object");
        }
    }

    class Circle : DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I am a Circle object");
        }
    }

    class Square : DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I am a Square object");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<DrawingObject> objs = new List<DrawingObject>() { new Line(), new Circle(), new Square(), new DrawingObject()};
            foreach (DrawingObject obj in objs)
            {
                obj.Draw();
            }
        }
    }
}
