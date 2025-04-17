using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_5
{
    internal class PersonalComputer : ISwitchable
    {
        public void TurnOn()
        {
            Console.WriteLine("Компьютер включён.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Компьютер выключен.");
        }
    }
}
