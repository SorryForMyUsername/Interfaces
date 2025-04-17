using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ISwitchable> switchables = new List<ISwitchable>();
            switchables.Add(new PersonalComputer());
            switchables.Add(new TVSet());

            foreach (var s in switchables)
            {
                s.TurnOn();
                s.TurnOff();
                Console.WriteLine();
            }
        }
    }
}
