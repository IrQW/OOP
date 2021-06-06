using System;

namespace ConsoleApplication1.Properties.transport.air
{
    public class MagicCarpet : AirTransport
    {
        public MagicCarpet() : base(10, (dist) => (dist < 1000) ? 0 : ((dist < 5000) ? 3 : ((dist < 10000) ? 10 : 5)))
        {
        }
    }
}