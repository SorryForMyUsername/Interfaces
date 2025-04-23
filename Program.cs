using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_2
{
    internal class Program
    {
        static List<BMV> BMVs = new List<BMV>();
        static List<Vaz> vazs = new List<Vaz>();
        static List<Maz> mazs = new List<Maz>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите действие:\n" +
                    "1. Добавить Vaz\n" +
                    "2. Добавть Maz\n" +
                    "3. Добавить BMV\n" +
                    "4. Вывести информацию об автомобилях Vaz\n" +
                    "5. Вывести информацию об автомобилях Maz\n" +
                    "6. Вывести информацию об автомобилях BMV\n" +
                    "7. Вывести информацию обо всех автомобилях\n" +
                    "8. Выход");

                while (true)
                {
                    int choice = Console.ReadKey(true).KeyChar - 48;

                    switch (choice)
                    {
                        case 1: vazs.Add(Vaz.Input()); break;
                        case 2: mazs.Add(Maz.Input()); break;
                        case 3: BMVs.Add(BMV.Input()); break;
                        case 4: OutputVazs(); Console.ReadKey(true); break;
                        case 5: OutputMazs(); Console.ReadKey(true); break;
                        case 6: OutputBMVs(); Console.ReadKey(true); break;
                        case 7: OutputAutos(); Console.ReadKey(true); break;
                        case 8: return;
                        default: continue;
                    }
                    Console.Clear();
                    break;
                }
            }
        }

        static void OutputMazs()
        {
            foreach(Maz maz in mazs)
            {
                maz.Show();
                maz.Turbo();
            }
        }

        static void OutputVazs()
        {
            foreach(Vaz vaz in vazs)
            {
                vaz.Show();
                vaz.Eco();
            }
        }

        static void OutputBMVs()
        {
            foreach(BMV bmv in BMVs)
            {
                bmv.Show();
                bmv.Eco();
                bmv.Turbo();
            }
        }

        static void OutputAutos()
        {
            OutputVazs();
            OutputBMVs();
            OutputMazs();
        }
    }
}
