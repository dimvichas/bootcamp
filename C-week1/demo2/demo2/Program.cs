using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a number between 1 and 6: ");
            string NumberStr1 = Console.ReadLine();
            int Number1 = Int32.Parse(NumberStr1);
            
            Console.Write("Give me a number between 1 and 6: ");
            string NumberStr2 = Console.ReadLine();
            int Number2 = Int32.Parse(NumberStr2);

            if ( Number1 > 6 && Number2 > 6)
            {
                Console.WriteLine("The numbers you gave are not valide");
            }
            else if (Number1>6)
            {
                Console.WriteLine("The first number you gave are not valide");
            }
            else if (Number2 > 6)
            {
                Console.WriteLine("The second number you gave are not valide");
            }
            else
            {
                Random r = new Random();
                int LotteryNumber1 = r.Next(1, 7);
                int LotteryNumber2 = r.Next(1, 7);
                if (Number1 == LotteryNumber1 && Number2 == LotteryNumber2)
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("You loose \nThe winning numbers are " + LotteryNumber1.ToString() + ","+ LotteryNumber2.ToString());
                }
            }
            
            Console.ReadKey();
        }
    }
}
