using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_2
{
    internal class MyClass : IInterface
    {
        public int Int()
        {
            Random rnd = new Random();
            return rnd.Next(0, 100);
        }

        public double PI()
        {
            return Math.PI;
        }

        public int X2(int x)
        {
            return (int)Math.Pow(x, 2);
        }

        public double XSqrt(double x)
        {
            return Math.Sqrt(x);
        }
    }
}
