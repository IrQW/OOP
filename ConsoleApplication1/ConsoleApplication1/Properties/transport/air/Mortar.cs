using System;

namespace ConsoleApplication1.Properties.transport.air
{
    public class Mortar : AirTransport
    {
        public Mortar() : base(8, (_) => 6)
        {
        }
    }
}