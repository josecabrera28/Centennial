using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    internal class Program
    {
        public class Complex
        {
            //Atributes
            public int Real { get; }
            public int Imaginary { get; }
            public double Argument;
            public double Modulus;
            public static Complex Zero;

            //Constructor
            public Complex(int real = 0, int imaginary = 0)
            {
                Real = real;
                Imaginary = imaginary;
                Modulus = Math.Pow((Real * Real) + (Imaginary * Imaginary), 0.5);
                Argument = Math.Tanh(Imaginary / Real);
            }

            //Methods

            public override string ToString()
            {
                return $"({Real},{Imaginary})";
            }

            public static Complex operator +(Complex lhs, Complex rhs)
            {
                int real = lhs.Real + rhs.Real;
                int imaginary = lhs.Imaginary + rhs.Imaginary;
                return new Complex(real, imaginary);
            }

            public static Complex operator -(Complex lhs, Complex rhs)
            {
                int real = lhs.Real - rhs.Real;
                int imaginary = lhs.Imaginary - rhs.Imaginary;
                return new Complex(real, imaginary);
            }

            public static bool operator ==(Complex lhs, Complex rhs)
            {
                bool result;
                if (lhs.Real == rhs.Real && lhs.Imaginary == rhs.Imaginary)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
                return result;
            }

            public static bool operator !=(Complex lhs, Complex rhs)
            {
                bool result;
                if (lhs.Real == rhs.Real && lhs.Imaginary == rhs.Imaginary)
                {
                    result = false;
                }
                else
                {
                    result = true;
                }
                return result;
            }
        }
        static void Main(string[] args)
        {
            Complex c0 = new Complex(-2, 3);
            Complex c1 = new Complex(-2, 3);
            Complex c2 = new Complex(1, -2);

            Console.WriteLine($"{c0}");
            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Console.WriteLine($"{c1} + {c2} = {c1 + c2}");
            Console.WriteLine($"{c1} - {c2} = {c1 - c2}");

            Complex c3 = c1 + c2;

            Console.WriteLine($"{c3} in polar form is {c3.Modulus:f2}cis({c3.Argument:f2})");

            Console.WriteLine($"{c0} {(c0 == c1 ? "=" : "!=")} {c1}");
            Console.WriteLine($"{c0} {(c0 == c2 ? "=" : "!=")} {c2}");

        }
    }
}
