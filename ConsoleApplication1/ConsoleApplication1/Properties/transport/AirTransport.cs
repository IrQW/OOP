using System;
using ConsoleApplication1.Properties.exceptions;

namespace ConsoleApplication1.Properties.transport
{
    public abstract class AirTransport : Transport
    {
        private double _speed;
        private Func<double, double> _multiplier;
        protected AirTransport(double speed, Func<double, double> multiplier)
        {
            if (speed <= 0)
            {
                throw new InvalidSpeed(speed);
            }

            _speed = speed;
            _multiplier = multiplier;
        }

        public double GetTime(double dist)
        {
            return dist * (100 - _multiplier(dist)) / 100 / _speed;
        }
    }
}