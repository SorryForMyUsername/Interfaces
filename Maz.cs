using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_2
{
    class Maz : Avto, ITurbo
    {
        public Maz(string dop, string model, int speed) : base(dop, model, speed) { }

        public override void Drive()
        {
            Console.WriteLine($"{Model}: Drive (Maz)");
        }

        public static Maz Input()
        {
            Console.Write("Dop: ");
            string dop = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Speed: ");
            int speed = int.Parse(Console.ReadLine());
            return new Maz(dop, model, speed);
        }

        public void Turbo()
        {
            Console.WriteLine($"{Model}: Turbo (Maz)");
        }
    }
}
