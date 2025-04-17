using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_6
{
    class Aa : A
    {
        int z;

        public Aa(int a, int b, int z) : base(a, b)
        {
            this.z = z;
        }

        new public int Sum()
        {
            int result = x + y + z;
            Console.WriteLine($"{x} + {y} + {z} = {result}");
            return result;
        }

        new public int Multiply()
        {
            int result = x * y * z;
            Console.WriteLine($"{x} * {y} * {z} = {result}");
            return result;
        }

        new public static Aa Input()
        {
            Console.WriteLine("obj2:");
            Console.Write("Переменная x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Переменная y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Переменная z: ");
            int z = int.Parse(Console.ReadLine());
            return new Aa(x, y, z);
        }
    }
}
