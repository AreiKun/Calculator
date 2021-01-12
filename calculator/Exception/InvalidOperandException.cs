using System;
using System.Runtime.Serialization;

namespace calculator.Logic
{
    public class InvalidOperandException : SystemException
    {
        public InvalidOperandException() { }

        public InvalidOperandException(string message) : base(message) { }

        public InvalidOperandException(string message, Exception inner) : base(message, inner) { }

        protected InvalidOperandException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
