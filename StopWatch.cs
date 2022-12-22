using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Program
    {

        static void Main(string[] args)
        {
            Menu();

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s");
            Console.WriteLine("M = Minutos => 1m");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
            {
                multiplier = 60;
            }

            if (time == 0)
            {
                System.Environment.Exit(0);
            }


            Start(time * multiplier);

        }

        static void Start(int time)
        {
            Console.Clear();

            int currentTime = 0;

            while (currentTime != time)
            {
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
                Console.Clear();

            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(3500);
            Menu();



        }
    }


}