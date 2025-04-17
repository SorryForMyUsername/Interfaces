using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dClass = new DerivedClass();
            dClass.Method();

            IInterface iClass = dClass;
            iClass.Method();

            Console.ReadKey(true);
        }
    }
}
