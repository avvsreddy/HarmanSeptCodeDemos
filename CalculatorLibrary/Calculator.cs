namespace CalculatorLibrary
{

    /// <summary>
    /// Calculates mathematical calculations such as find sum....
    /// </summary>
    public class Calculator // Businee Class - SRP - BL
    {

        /// <summary>
        /// Finds sum of two non zero ints
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>sum of two numbers</returns>
        /// <exception cref="NonZeroNumberException"></exception>
        public int FindSum(int a, int b)
        {
            if (a == 0 || b == 0)
                throw new NonZeroNumberException("Please enter non zero numbers only");

            /*fsdfsdfsd
             * sdfsdfsdf
             * asdfsdfasdf
             * 
             * */


            return a + b;
        }
    }
}
