using ConsoleApplication1.Properties.transport;

namespace ConsoleApplication1.Properties.race
{
    public class RoadRace : Race
    {
        public RoadRace(params RoadTransport[] roadTransports) : base(roadTransports)
        {
        }
        
        public override void AddTransport(Transport roadTransport)
        {
            AddTransport<RoadTransport>(roadTransport);
        }
    }
}