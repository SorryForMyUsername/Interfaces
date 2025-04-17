using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_7
{
    internal class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Проигрывание началось");
        }

        public void Record()
        {
            Console.WriteLine("Запись началась");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Проигрывание приостановлено");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Запись приостановлена");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Проигрывание поставлено на паузу");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Запись поставлена на паузу");
        }
    }
}
