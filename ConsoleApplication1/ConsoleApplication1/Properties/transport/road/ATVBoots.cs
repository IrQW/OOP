using System;

namespace ConsoleApplication1.Properties.transport.road
{
    public class ATVBoots : RoadTransport
    {
        public ATVBoots() : base(6, 60, (count) => (count == 1) ? 10 : 5)
        {
        }
    }
}