using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_1
{
    internal class Disk : IShape
    {
        int radius;

        public int Radius
        {
            get { return radius; }
            set
            {
                if(radius < 0)
                {
                    radius = 0;
                }
                radius = value;
            }
        }

        public Disk(int radius)
        {
            Radius = radius;
        }

        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public static Disk Input()
        {
            Console.WriteLine("Создание круга.");
            Console.Write("Радиус: ");
            int radius = int.Parse(Console.ReadLine());
            return new Disk(radius);
        }

        public override string ToString()
        {
            return $"Фигура: Круг" +
                $"Радиус - {Radius}";
        }
    }
}
