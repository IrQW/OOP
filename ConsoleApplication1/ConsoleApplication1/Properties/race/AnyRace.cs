using ConsoleApplication1.Properties.transport;

namespace ConsoleApplication1.Properties.race
{
    public class AnyRace : Race
    {
        public AnyRace(params Transport[] transports) : base(transports)
        {
        }

        public override void AddTransport(Transport transport)
        {
            AddTransport<Transport>(transport);
        }
    }
}