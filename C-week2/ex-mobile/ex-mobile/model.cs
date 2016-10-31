using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_mobile
{
    class device
    {
        public string Model { get; private set; }
        public string Manufacturer { get; private set; }
        public decimal Base_price { get; private set; }
        public screen Screen { get; private set; }
        public battery Battery { get; private set; }

        public Usage Usage { get; private set; }
        

        public device(string model, string manufacturer, decimal price, screen screen, battery battery)
        {
            Model = model;
            Manufacturer = manufacturer;
            Base_price = price;
            Screen = screen;
            Battery = battery;
        }
        public static device LG_G3()
        {
            string model = "G3";
            string manufacturer = "LG";
            decimal price = 300;
            screen screen = new screen("1440 x 2560", 538);
            battery battery = new battery("Li-ion", 3000);

            return new device (model, manufacturer, price, screen, battery);
        }
    }
}
