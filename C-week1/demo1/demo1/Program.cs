using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Give me a number between 1 and 6: ");
            string NumberStr = Console.ReadLine();
            int Number = Int32.Parse(NumberStr);
            if (Number >= 6)
            {
                Console.WriteLine("Not valide number");
            }
            else
            {

                Random r = new Random();
                int LotteryNumber = r.Next(1, 7);
                if (Number == LotteryNumber)
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("You loose \nThe winning number is " + LotteryNumber);
                }
            }

            Console.ReadKey();
        }
    }
}
