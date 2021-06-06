using System;

namespace ConsoleApplication1.Properties.transport.road
{
    public class SpeedCamel : RoadTransport
    {
        public SpeedCamel() : base(40, 10, (count) => (count == 1) ? 5 : ( (count == 2) ? 6.5 : 8 ))
        {
        }
    }
}