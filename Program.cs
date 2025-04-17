using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            int x1 = myClass.Int();
            Console.WriteLine($"x | x^2 = {x1} | {myClass.X2(x1)}");
            Console.WriteLine($"Sqrt(PI) = {myClass.XSqrt(myClass.PI()):f2}\n");

            IInterface iClass = myClass;
            int x2 = myClass.Int();
            Console.WriteLine($"x | x^2 = {x2} | {myClass.X2(x2)}");
            Console.WriteLine($"Sqrt(PI) = {myClass.XSqrt(myClass.PI()):f2}");

            Console.ReadKey();
        }
    }
}
