using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo6
{
    public class Program
    {
        public class Randomizer<T>
        {
            public List<T> Items { get; set; }
            public T GetRandomItem()
            {
                Random r = new Random();
                return Items[r.Next(0, Items.Count)];
            }
        }
        public class Currency
        {
            private readonly String _name;
            public String Name
            {
                get { return _name; }
            }

            private readonly String _abbr;
            public String Abbr
            {
                get { return _abbr; }
            }
            public Currency(String Name, String Abbr)
            {
                _name = Name;
                _abbr = Abbr;
            }
        }
        public class ApplicationSettings
        {
            private static ApplicationSettings _instance;
            private ApplicationSettings()
            {

            }
            public static ApplicationSettings Get()
            {
                if (_instance == null) _instance = new ApplicationSettings();
                return _instance;
            }
        }
        public static void Main(string[] args)
        {

        }
    }
}
