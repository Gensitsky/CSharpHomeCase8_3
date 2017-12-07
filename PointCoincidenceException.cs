using System;

namespace CSharpHomeCase8_3
{
    [Serializable]
    public class PiontCoincidenceException : ApplicationException
    {
        public PiontCoincidenceException() { }
        public PiontCoincidenceException(string message) : base(message) { }
        public PiontCoincidenceException(string message, Exception inner) : base(message, inner) { }
        protected PiontCoincidenceException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
