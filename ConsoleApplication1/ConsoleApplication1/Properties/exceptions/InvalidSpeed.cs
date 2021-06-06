using System;

namespace ConsoleApplication1.Properties.exceptions
{
    public class InvalidSpeed : Exception
    {
        public InvalidSpeed(double speed) : base($"Speed ({speed}) must be positive!")
        {
        }
    }
}