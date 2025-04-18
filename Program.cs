using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();
            while (true)
            {
                Console.WriteLine("Выберите действие:\n" +
                    "1. Добавить треугольник\n" +
                    "2. Добавить круг\n" +
                    "3. Вывести фигуры\n" +
                    "4. Выйти из приложения\n");

                int choice = Console.ReadKey(true).KeyChar - 48;

                switch (choice)
                {
                    case 1: shapes.Add(Triangle.Input()); break;
                    case 2: shapes.Add(Disk.Input()); break;
                    case 3: OutputShapes(shapes);  break;
                    case 4: return;
                }

                Console.WriteLine();
            }
        }

        public static void OutputShapes(List<IShape> shapes)
        {
            foreach (IShape shape in shapes)
            {
                OutputShape(shape);
            }
        }

        public static void OutputShape(IShape shape)
        {
            Console.WriteLine($"{shape}\n" +
                $"Периметр - {shape.Perimeter()}\n" +
                $"Площадь - {shape.Area()}");
            
        }
    }
}
