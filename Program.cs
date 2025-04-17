using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _37_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player();
            IPlayable playable = p;
            IRecodable recodable = p;

            playable.Play();
            Thread.Sleep(1000);
            playable.Pause();
            Thread.Sleep(300);
            recodable.Record();
            Thread.Sleep(500);
            playable.Play();
            Thread.Sleep(2000);
            recodable.Stop();
            Thread.Sleep(300);
            playable.Stop();

            Console.ReadKey(true);
        }
    }
}
