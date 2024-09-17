using System.Runtime.Serialization;

namespace CalculatorLibrary
{
    // custom exp


    public class NonZeroNumberException : ApplicationException
    {
        public NonZeroNumberException()
        {

        }
        public NonZeroNumberException(string msg) : base(msg)
        {

        }

        protected NonZeroNumberException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
