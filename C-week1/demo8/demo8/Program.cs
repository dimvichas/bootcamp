using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dice dice = new Dice();
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Give me a number between 1 and 6: ");
                string NumberStr = Console.ReadLine();
                dice.Throw(NumberStr);
                if (dice.Success)
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine($"You loose. The winning number was {dice.Result.ToString()}");
                }
            }
            Console.ReadKey();

            DiceWithSecondChoice Dice = new DiceWithSecondChoice();
            Console.Write("Give me a number between 1 and 6: ");
            string NumberStr1 = Console.ReadLine();
            Dice.ThrowSecondChoice(NumberStr1);
            if (Dice.Success)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine($"You loose. The winning number was {dice.Result.ToString()}");
            }

            DiceWithSecondChoiceOverride dicenew = new DiceWithSecondChoiceOverride();
            Console.Write("Give me a number between 1 and 6: ");
            NumberStr1 = Console.ReadLine();
            dicenew.Throw(NumberStr1);
            if (dicenew.Success)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You loose. The winning number was " + $"{dicenew.Result.ToString()}");
            }
        }
    }
}
