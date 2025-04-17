using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_6
{
    interface IBasicOperations
    {
        int Sum(int x, int y);
        int Sub(int x, int y);
        int Multiply(int x, int multiplier);
        int Divide(int x, int divider);
    }
}
