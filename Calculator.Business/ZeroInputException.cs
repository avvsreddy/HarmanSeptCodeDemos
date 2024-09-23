namespace Calculator.Business
{
    public class ZeroInputException : ApplicationException
    {
        //public ZeroInputException()
        //{

        //}

        //public ZeroInputException(string msg) : base(msg)
        //{

        //}

        public ZeroInputException(string msg = null, Exception innerException = null) : base(msg, innerException)
        {

        }
    }
}
