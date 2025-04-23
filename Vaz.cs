using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_2
{
    internal class Vaz : Avto, IEco
    {
        public Vaz(string dop, string model, int speed) : base(dop, model, speed) { }

        public override void Drive()
        {
            Console.WriteLine($"{Model}: Drive (Vaz)");
        }

        public static Vaz Input()
        {
            Console.Write("Dop: ");
            string dop = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Speed: ");
            int speed = int.Parse(Console.ReadLine());
            return new Vaz(dop, model, speed);
        }

        public void Eco()
        {
            Console.WriteLine($"{Model}: Eco (Vaz)");
        }
    }
}
