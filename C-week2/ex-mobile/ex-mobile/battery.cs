using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_mobile
{
    class battery
    {
        public string Type { get; private set; }
        public int Capacity { get; private set; }

        public battery(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
        }
    }
}
