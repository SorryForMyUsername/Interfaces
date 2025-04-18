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

        public string Dop { get => dop; set => dop = value; }
        public string Model { get => model; set => model = value; }
        public int Speed { get => speed; set => speed = value; }

        public Avto(string dop, string model, int speed)
        {
            Dop = dop;
            Model = model;
            Speed = speed;
        }

        public abstract void Drive();

        public virtual void Show()
        {

        }
    }
}
