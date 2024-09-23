
namespace Calculator.Business
{
    public class SimpleCalculator
    {
        /// <summary>
        /// finds the sum of two ints and returns the sum
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int FindSum(int a, int b)
        {
            // non zero values
            if (a == 0 || b == 0)
                throw new ZeroInputException("Provide non-zero input only");

            if (a == -1 || b == -1)
                throw new NegativeInputException("Provide positive input only");
            return a + b;
        }

        public int Subtract(int no1, int no2)
        {
            if (no1 == 0 || no2 == 0)
                throw new ZeroInputException("Provide non-zero input only");
            return no1 - no2;
        }
    }
}
