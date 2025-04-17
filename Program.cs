using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.LoudSpeak();
            person.Think();
            person.NormalSpeak();

            Console.ReadKey(true);
        }
    }
}
