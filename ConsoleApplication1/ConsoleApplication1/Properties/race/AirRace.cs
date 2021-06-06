using ConsoleApplication1.Properties.transport;

namespace ConsoleApplication1.Properties.race
{
    public class AirRace : Race
    {
        public AirRace(params AirTransport[] airTransports) : base(airTransports)
        {
        }
        
        public override void AddTransport(Transport airTransport)
        {
            AddTransport<AirTransport>(airTransport);
        }
    }
}