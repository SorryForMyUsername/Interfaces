using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_2
{
    class BMV : Avto, IEco, ITurbo
    {
        int enginePower;
        int fuelConsumption;

        public int EnginePower
        {
            get { return enginePower; }
            set
            {
                if(value < 0)
                {
                    enginePower = 0;
                }
                enginePower = value;
            }
        }
        public int FuelConsumption
        {
            get { return fuelConsumption; }
            set
            {
                if(value < 0)
                {
                    fuelConsumption = 0;
                }
                fuelConsumption = value;
            }
        }

        public BMV(string dop, string model, int speed, int enginePower, int fuelConsumption) : base(dop, model, speed)
        {
            EnginePower = enginePower;
            FuelConsumption = fuelConsumption;
        }

        public override void Drive()
        {
            Console.WriteLine($"{Model}: Drive (BMV)");
        }

        public void Eco()
        {
            Console.WriteLine($"{Model}: Eco (BMV)");
        }

        public void Turbo()
        {
            Console.WriteLine($"{Model}: Turbo (BMV)");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Мощность двигателя: {EnginePower}\n" +
                $"Расход топлива: {FuelConsumption}");
        }

        public static BMV Input()
        {
            Console.Write("Dop: ");
            string dop = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Speed: ");
            int speed = int.Parse(Console.ReadLine());
            Console.Write("Engine power: ");
            int enginePower = int.Parse(Console.ReadLine());
            Console.Write("Fuel consumption: ");
            int fuelConsumption = int.Parse(Console.ReadLine());
            return new BMV(dop, model, speed, enginePower, fuelConsumption);
        }
    }
}
