using System;
using ConsoleApplication1.Properties.race;
using ConsoleApplication1.Properties.transport.air;
using ConsoleApplication1.Properties.transport.road;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var a = new Engine();
            a.CreateRace(new AnyRace(new Broom(), new SpeedCamel(), new Broom()));
            a.RegisterTransport(new Mortar());
            Console.WriteLine(a.RunRace(5000));
        }
    }
}