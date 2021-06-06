using System;

namespace ConsoleApplication1.Properties.exceptions
{
    public class InvalidWorkingTime : Exception
    {
        public InvalidWorkingTime(double workingTime) : base($"Working time ({workingTime}) must be positive!")
        {
        }
    }
}