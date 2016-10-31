using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        public class Student : IComparable<Student>
        {
            public string Name;
            public double Mark;

            public Student(string name, double mark)
            {
                this.Mark = mark;
                this.Name = name;
            }
            public int CompareTo(Student s2)
            {
                if(this.Mark > s2.Mark)
                {
                    return -1;
                }
                else if(this.Mark < s2.Mark)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        static void Main(string[] args)
        {
            List<Student> items = new List<Student>()
            {
                new Student("Nikos", 4),
                new Student("Kwstas", 6.5),
                new Student("Dimitris", 9.3),
                new Student("Giannis", 2.8),
                new Student("Giorgos", 7.6),
                new Student("Maria", 8)
            };
            foreach (Student s in items)
            {
                Console.WriteLine("{0} got {1}", s.Name, s.Mark);
            }
            Console.WriteLine();
            items.Sort();
            foreach (Student s in items)
            {
                Console.WriteLine("{0} got {1}", s.Name, s.Mark);
            }
            Console.ReadKey();
        }
    }
}
