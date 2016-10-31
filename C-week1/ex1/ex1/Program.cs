using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        public class Complex
        {
            private double a;
            public double Real
            {
                get { return a; }
                set { a = value; }
            }
            private double b;
            public double Imaginary
            {
                get { return b; }
                set { b = value; }
            }

            public Complex()
            {
                a = 0;
                b = 0;
            }
            public Complex(double x)
            {
                a = x;
                b = 0;
            }
            public Complex(double x, double y)
            {
                a = x;
                b = y;
            }
            
            public static Complex Add(Complex x, Complex y)
            {
                double r = x.Real + y.Real;
                double i = x.Imaginary + y.Imaginary;
                return new Complex(r, i);
            }
            
            public Complex Add(Complex x)
            {
                double r = this.a + x.Real;
                double i = this.Imaginary + x.Imaginary;
                Complex z = new Complex(r, i);
                return z;
            }
            
            public static Complex operator +(Complex x, Complex y)
            {
                return new Complex(x.a + y.a, x.b + y.b);
            }
            
            public override string ToString()
            {
                return $"{this.Real} + {this.Imaginary} i";
            }
        }

        static void Main(string[] args)
        {
            Complex z1 = new Complex(5);
            Complex z2 = new Complex(2, 10);
            Complex z3 = new Complex(1, 1);
            
            Complex sum1 = z1.Add(z2);
            Complex sum2 = Complex.Add(z1, z2);
            Complex sum3 = z1 + z2;
            
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
            
            Complex sum4 = z1.Add(z2).Add(z3);
            Complex sum5 = Complex.Add(z1, z2).Add(z3);
            Complex sum6 = z1 + z2 + z3;
            
            Console.WriteLine(sum4);
            Console.WriteLine(sum5);
            Console.WriteLine(sum6);

            Console.ReadKey();
        }
    }
}
