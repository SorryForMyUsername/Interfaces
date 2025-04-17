using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_4
{
    internal class Person : ISpeak, IReflection
    {
        public void LoudSpeak()
        {
            Console.WriteLine("Говорит громко - Я люблю программирование!");
        }

        public void NormalSpeak()
        {
            Console.WriteLine("Говорит нормально - Меньше люблю компьютерные игры");
        }

        public void Think()
        {
            Console.WriteLine("Думает - А C# больше всего");
        }
    }
}
