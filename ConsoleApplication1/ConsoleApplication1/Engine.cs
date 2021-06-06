using ConsoleApplication1.Properties.race;
using ConsoleApplication1.Properties.transport;

namespace ConsoleApplication1
{
    public class Engine
    {
        private Race _race;

        public Engine(Race race)
        {
            _race = race;
        }

        public Engine()
        {
        }

        public void CreateRace(Race race)
        {
            _race = race;
        }

        public void RegisterTransport(Transport transport)
        {
            _race.AddTransport(transport);
        }

        public Transport RunRace(double dist)
        {
            return _race.Run(dist);
        }
    }
}