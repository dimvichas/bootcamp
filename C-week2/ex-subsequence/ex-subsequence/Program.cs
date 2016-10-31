using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_subsequence
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 5, 10, 10, 4, 4, 4, 2, 3, 6, 6, 6, 6 };

            List<int> sequence = utilities.Subsequence(list);
            sequence.ForEach(x => Console.Write(x + " "));

            List<int> sequence1 = list.Subsequence();
            sequence1.ForEach(x => Console.Write(x + " "));

            List<int> sequence2 = utilities.SubLINQ(list);
            sequence2.ForEach(x => Console.Write(x + " "));

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
