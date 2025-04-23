using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_2
{
    abstract class Avto
    {
        string dop;
        string model;
        int speed;

        public string Dop
        {
            get { return dop; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    dop = "Неизвестно";
                }
                dop = value;
            }
        }
        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    model = "Неизвестно";
                }
            }
        }
        public int Speed
        {
            get { return speed; }
            set
            {
                if(value < 0)
                {
                    speed = Math.Abs(value);
                }
                speed = value;
            }
        }

        public Avto(string dop, string model, int speed)
        {
            Dop = dop;
            Model = model;
            Speed = speed;
        }

        public abstract void Drive();

        public virtual void Show()
        {
            Console.WriteLine($"Dop: {Dop}\n" +
                $"Модель: {Model}\n" +
                $"Скорость: {Speed}");
        }
    }
}
