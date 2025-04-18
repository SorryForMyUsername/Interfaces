using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_1
{
    internal class Triangle : IShape
    {
        int side1;
        int side2;
        int side3;

        public int Side1
        {
            get { return side1; }
            set
            {
                CheckSidesValue(value, side2, side3);
                side1 = value;
            }
        }
        public int Side2
        {
            get { return side2; }
            set
            {
                CheckSidesValue(value, side1, side3);
                side2 = value;
            }
        }
        public int Side3
        {
            get { return side3; }
            set
            {
                CheckSidesValue(value, side1, side2);
                side3 = value;
            }
        }

        public Triangle() { }

        public Triangle(int side1, int side2, int side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double Area()
        {
            double p = (Side1 + Side2 + Side3) / 2d;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        public double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }

        private void CheckSidesValue(int value, int anotherSide1, int anotherSide2)
        {
            if (value <= 0 || ((value > anotherSide1 + anotherSide2 || anotherSide1 > value + anotherSide2 || anotherSide2 > value + anotherSide1) && anotherSide1 > 0 && anotherSide2 > 0))
            {
                throw new Exception("Треугольника с такими сторонами не может существовать");
            }
        }

        public static Triangle Input()
        {
            Triangle t = new Triangle();
            while (true)
            {
                try
                {
                    Console.WriteLine("Создание треугольника.");
                    Console.Write("1-я сторона: ");
                    int side1 = int.Parse(Console.ReadLine());
                    Console.Write("2-я сторона: ");
                    int side2 = int.Parse(Console.ReadLine());
                    Console.Write("3-я сторона: ");
                    int side3 = int.Parse(Console.ReadLine());
                    t = new Triangle(side1, side2, side3);
                    break;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Треугольник не создан, так как вызвано исключение!\n" +
                        $"Сообщение: {ex.Message}\n");
                }
            }
            return t;
        }

        public override string ToString()
        {
            return $"Фигура: Треугольник\n" +
                $"1-я сторона - {Side1}\n" +
                $"2-я сторона - {Side2}\n" +
                $"3-я сторона - {Side3}";
        }
    }
}
