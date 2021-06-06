using System;

namespace ConsoleApplication1.Properties.transport.air
{
    public class Broom : AirTransport
    {
        public Broom() : base(20, (dist) => Math.Round(dist / 1000))
        {
        }
    }
}