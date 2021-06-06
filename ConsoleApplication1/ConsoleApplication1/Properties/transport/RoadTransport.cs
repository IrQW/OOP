using System;
using ConsoleApplication1.Properties.exceptions;

namespace ConsoleApplication1.Properties.transport
{
    public abstract class RoadTransport : Transport
    {
        private double _speed;
        private double _workingTime;
        private Func<int, double> _restTime;

        protected RoadTransport(double speed, double workingTime, Func<int, double> restTime)
        {
            if (speed <= 0)
            {
                throw new InvalidSpeed(speed);
            }
            
            if (workingTime <= 0 )
            {
                throw new InvalidWorkingTime(workingTime);
            }
            
            _speed = speed;
            _workingTime = workingTime;
            _restTime = restTime;
        }

        public double GetTime(double dist)
        {
            double time = 0;
            for (var i = 1; dist > 0; ++i)
            {
                if (_workingTime * _speed > dist)
                {
                    time += dist / _speed;
                    return time;
                }

                dist -= _workingTime * _speed;
                time += _workingTime + _restTime(i);
            }

            return -1;
        }
    }
}