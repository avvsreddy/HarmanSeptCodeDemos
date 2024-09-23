namespace Calculator.Business
{
    public class NegativeInputException : ApplicationException
    {
        public NegativeInputException(string msg = null, Exception innerExp = null) : base(msg, innerExp)
        {

        }
    }
}
