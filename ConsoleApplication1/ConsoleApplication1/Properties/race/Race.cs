using ConsoleApplication1.Properties.exceptions;
using System.Collections.Generic;
using ConsoleApplication1.Properties.transport;

namespace ConsoleApplication1.Properties.race
{
    public abstract class Race
    {
        private List <Transport> _transports;

        protected Race(params Transport[] transports)
        {
            _transports = new List<Transport>(transports);
        }

        public abstract void AddTransport(Transport transport);

        protected void AddTransport<T>(Transport transport)
        {
            if (transport is T)
            {
                _transports.Add(transport);
            }
            else
            {
                throw new InvalidTypeOfTransport(typeof(T), transport.GetType());
            }
        }
        
        public Transport Run(double dist)
        {
            var min = double.MaxValue;
            Transport winner = null;
            foreach (var i in _transports)
            {
                var time = i.GetTime(dist);
                if (time > min) continue;
                min = time;
                winner = i;
            }

            return winner;
        }
    }
}