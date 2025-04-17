using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_6
{
    class A : IBasicOperations
    {
        protected int x;
        protected int y;

        public A(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Divide()
        {
            int result = x / y;
            Console.WriteLine($"{x} / {y} = {result}");
            return result;
        }

        public int Multiply()
        {
            int result = x * y;
            Console.WriteLine($"{x} * {y} = {result}");
            return result;
        }

        public int Sub()
        {
            int result = x - y;
            Console.WriteLine($"{x} - {y} = {result}");
            return result;
        }

        public int Sum()
        {
            int result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
            return result;
        }

        public static A Input()
        {
            Console.WriteLine("obj1:");
            Console.Write("Переменная x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Переменная y: ");
            int y = int.Parse(Console.ReadLine());
            return new A(x, y);
        }
    }
}
