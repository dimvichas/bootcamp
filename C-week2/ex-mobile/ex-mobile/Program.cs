using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_mobile
{
    class Program
    {
        static void Main(string[] args)
        {
            device a = device.LG_G3();
            Console.WriteLine(a.Model + " " + a.Manufacturer + a.Screen.Resolution + "pixels");
            device b = new device("S7", "Samsung", 600, new screen("1440 x 2560", 577), new battery("Li-ion", 3000));
            Console.WriteLine(b.Model + " " + b.Screen.Pixels);
            
            a.Usage.NewCall(CallType.Incoming);
            Console.WriteLine("Call Started...");
            System.Threading.Thread.Sleep(5000);
            a.Usage.EndCall();
            Console.WriteLine("Call Ended");
            Console.WriteLine();

            a.Usage.NewCall(CallType.Outgoing);
            Console.WriteLine("Call Started...");
            System.Threading.Thread.Sleep(10000);
            a.Usage.EndCall();
            Console.WriteLine("Call Ended");

            Console.WriteLine(a.Usage);
            
            Console.ReadKey();
        }
    }
}
