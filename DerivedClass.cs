using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_3
{
    internal class DerivedClass : IInterface3
    {
        public void Method1()
        {
            Console.WriteLine("Метод Method1\n");
        }

        public void Method2()
        {
            Console.WriteLine("Метод Method2\n");
        }

        public void Method3()
        {
            Console.WriteLine("Метод Method3\n");
        }
    }
}
