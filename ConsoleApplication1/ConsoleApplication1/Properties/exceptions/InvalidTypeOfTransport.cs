using System;

namespace ConsoleApplication1.Properties.exceptions
{
    public class InvalidTypeOfTransport : Exception
    {
        public InvalidTypeOfTransport(Type correctType, Type invalideType) : base(
            $"{invalideType.Name} is invalide type of transport for this race! Correct type is {correctType.Name}")
        {
        }
    }
}