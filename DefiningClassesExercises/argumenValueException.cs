using System;
using System.Runtime.Serialization;

namespace DefiningClasses
{
    [Serializable]
    internal class argumenValueException : Exception
    {
        public argumenValueException()
        {
        }

        public argumenValueException(string message) : base(message)
        {
        }

        public argumenValueException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected argumenValueException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}