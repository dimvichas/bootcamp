using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        public enum Gender
        {
            Male,
            Female
        }
        public abstract class Animal
        {
            public int Age { get; protected set; }
            public string Name;
            public Gender Gender;
            protected string sound;

            public Animal(string name, int age, Gender gender)
            {
                Name = name;
                Age = age;
                Gender = gender;
            }

            public string MakeSound()
            {
                return sound;
            }
        }

        public class Dog : Animal
        {
            public Dog(string name, int age, Gender gender) : base(name, age, gender)
            {
                sound = "wuf wuf";
            }
        }

        public class Cat : Animal
        {
            public Cat(string name, int age, Gender gender) : base(name, age, gender)
            {
                sound = "meow!";
            }

        }

        public class Lion : Animal
        {
            public Lion(string name, int age, Gender gender) : base(name, age, gender)
            {
                sound = "Raaar!";
            }
        }
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
            {
                new Dog("Lucy", 5, Gender.Female),
                new Dog("Tom", 1, Gender.Male),
                new Cat("Neda", 4, Gender.Female),
                new Lion("Leo", 8, Gender.Male)
            };
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i].Name + " who is " + animals[i].Gender + " and " + animals[i].Age + " years, says \"" + animals[i].MakeSound() + "\"");
            }

            Console.ReadKey();
        }
    }
}
