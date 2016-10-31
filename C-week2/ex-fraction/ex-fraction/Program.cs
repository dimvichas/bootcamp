﻿using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace ex_fraction
{
    class Program
    {
        class Fraction : IComparable<Fraction>
        {
            private int numerator;
            private int denominator;

            public int Numerator
            {
                get
                {
                    return numerator;
                }

                set
                {
                    numerator = value;
                }
            }

            public int Denominator
            {
                get
                {
                    return denominator;
                }
                set
                {
                    if (value != 0)
                    {
                        denominator = value;
                    }
                    else
                    {
                        //throw new ArithmeticException();
                    }
                }
            }
            public decimal Decimal
            {
                get { return (decimal)numerator / (decimal)denominator; }
            }
            
            public Fraction()
            {
                Numerator = 0;
                Denominator = 1;
            }

            public Fraction(int num, int den)
            {
                Numerator = num;
                Denominator = den;
            }
            public override string ToString()
            {
                string result = "";
                if (numerator * denominator < 0)
                {
                    result += "-";
                }
                result += Math.Abs(numerator);
                result += "/";
                result += Math.Abs(denominator);
                return result;
            }
            public static Fraction operator *(Fraction a, Fraction b)
            {
                int num = a.Numerator * b.Numerator;
                int den = a.Denominator * b.Denominator;
                return new Fraction(num, den);
            }
            public static Fraction operator *(int a, Fraction b)
            {
                int num = a * b.Numerator;
                int den = b.Denominator;
                return new Fraction(num, den);
            }
            public static Fraction operator *(Fraction a, int b)
            {
                return b * a;
            }
            public static Fraction Parse(string str)
            {
                string[] split = str.Split('/');
                //string[] split = str.Split(new char[] { '/' });
                if (split.Length != 2)
                {
                    //throw new ArithmeticException;
                }
                int num;
                if (!Int32.TryParse(split[0], out num))
                {
                    //throw new ArithmeticException;
                }
                int den;
                if (!Int32.TryParse(split[1], out den))
                {
                    //throw new ArithmeticException;
                }
                return new Fraction(num, den);
            }
            public int CompareTo(Fraction other)
            {
                if (this.Decimal < other.Decimal)
                {
                    return -1;
                }
                else if (this.Decimal > other.Decimal)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            public void Cancel()
            {
                int min = Math.Min(this.Numerator, this.Denominator);
                for (int i = min; i >= 2; i--)
                {
                    if ((this.Numerator % i) == 0 && (this.Denominator % i) == 0)
                    {
                        this.Numerator /= i;
                        this.Denominator /= i;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Fraction c1 = new Fraction(-2, -5);
            Fraction c2 = new Fraction(3, 5);
            Console.WriteLine(c1);

            Fraction c3 = c1 * c2;
            Fraction c4 = c2 * c1;
            Fraction c5 = 5 * c4;
            Fraction c6 = c5 * 10;
            Fraction c7 = c1 * c2 * c3 * c5 * 8;

            Console.WriteLine(c7);
            Console.WriteLine(c7.Decimal);

            Fraction c8 = Fraction.Parse("2/5");

            List<Fraction> list = new List<Fraction>()
            {
                c1, c2, c3, c4, c5, c6, c7, new Fraction(2, 10)
            };
            Console.WriteLine("Before Sort\n");
            foreach (Fraction f in list)
            {
                Console.WriteLine(f);
            }
            list.Sort();
            Console.WriteLine("After Sort\n");
            foreach (Fraction f in list)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine("Test Cancel()");
            Console.Write(c7 + " ==> ");
            c7.Cancel();
            Console.WriteLine(c7);

            Console.ReadKey();
        }
    }
}
