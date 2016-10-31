using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dice dice = new Dice();
            for(int i=0; i<2; i++)
            {
                Console.WriteLine("Give me a number between 1 and 6: ");
                string NumberStr = Console.ReadLine();
                int Number = Int32.Parse(NumberStr);

                dice.Throw(Number);
                if (dice.Success)
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("You loose \nThe winning number was " + dice.Result.ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
