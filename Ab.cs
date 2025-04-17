using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_6
{
    class Ab : A, IExtendedOperations
    {
        public Ab(int a, int b) : base(a, b) { }

        public int Pow()
        {
            int result = (int)Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {result}");
            return result;
        }

        public double Sqrt()
        {
            double result = Math.Sqrt(x);
            Console.WriteLine($"Sqrt({x}) = {result}");
            return result;
        }

        new public static Ab Input()
        {
            Console.WriteLine("obj3:");
            Console.Write("Переменная x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Переменная y: ");
            int y = int.Parse(Console.ReadLine());
            return new Ab(x, y);
        }
    }
}
