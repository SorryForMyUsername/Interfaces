using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Объект DerivedClass:");
            DerivedClass dClass = new DerivedClass();
            dClass.Method1();
            dClass.Method2();
            dClass.Method3();

            Console.WriteLine("\nОбъект IInterface3:");
            IInterface3 i3Class = dClass;
            i3Class.Method1();
            i3Class.Method2();
            i3Class.Method3();

            Console.WriteLine("\nОбъект IInterface2:");
            IInterface2 i2Class = dClass;
            i2Class.Method1();
            i2Class.Method2();

            Console.WriteLine("\nОбъект IInterface1:");
            IInterface1 i1Class = dClass;
            i1Class.Method1();

            Console.ReadKey(true);
        }
    }
}
