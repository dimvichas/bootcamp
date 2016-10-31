using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_mobile
{
    class screen
    {
        public string Resolution { get; private set; }
        public int Pixels { get; private set; }

        public screen(string resolution, int pixels)
        {
            Resolution = resolution;
            Pixels = pixels;
        }
    }
}
