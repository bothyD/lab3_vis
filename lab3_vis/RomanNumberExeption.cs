using System;

namespace lab3_vis
{
    public class RomanNumberException : Exception
    {
        public RomanNumberException() : base() { }
        public RomanNumberException(string message) : base(message) { }
    }
}