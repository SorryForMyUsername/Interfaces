using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_2
{
    class Maz : Avto, ITurbo
    {
        public override void Drive()
        {
            throw new NotImplementedException();
        }

        public void Turbo()
        {
            throw new NotImplementedException();
        }

        public override void Show()
        {
            base.Show();
        }
    }
}
