using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3._1
{
    public class Dice
    {

        private static Random _r { get; set; }
        private int _result { get; set; }
        private int _choice { get; set; }
        public bool _success { get; set; }

        public Dice()
        {
            if (Dice._r == null)
            {
                Dice._r = new Random();
            }
        }
        public void Throw(int Number)
        {
            _choice = Number;
            _result = _r.Next(1, 7);
            if (Number == _result)
            {
                _success = true;
            }
            else
            {
                _success = false;
            }
        }
        public string GetResultMessage()
        {
            if (_success)
            {
                return "You win";
            }
            else
            {
                return $"You loose. The winning number was {Dice._r.ToString()}";
            }
        }

    }
}
