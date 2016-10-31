using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3._1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dice dice = new Dice();
            for (int i=0; i<2; i++)
            {
                Console.Write("Give me a number between 1 and 6: ");
                string NumberStr = Console.ReadLine();
                int Number = Int32.Parse(NumberStr);

                dice.Throw(Number);
                Console.WriteLine(dice.GetResultMessage());
            }
            Console.ReadKey();
        }
    }
}
