using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = A.Input();
            a.Sum();
            a.Multiply();
            Console.WriteLine();

            Aa aa = Aa.Input();
            aa.Sum();

            Console.ReadKey(true);
        }
    }
}
