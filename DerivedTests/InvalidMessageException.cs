using System;

namespace DerivedTests
{
    public class InvalidMessageException : Exception
    {
        public InvalidMessageException(string message) : base(message)
        {
        }
    }
}