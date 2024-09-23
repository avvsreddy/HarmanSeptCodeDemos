
namespace Calculator.Business
{
    public class SimpleCalculator
    {
        private readonly ICalculatorRepo repo;

        /// <summary>
        /// finds the sum of two ints and returns the sum
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// 

        public SimpleCalculator(ICalculatorRepo repo)
        {
            this.repo = repo;
        }
        public int FindSum(int a, int b)
        {
            // non zero values
            if (a == 0 || b == 0)
                throw new ZeroInputException("Provide non-zero input only");

            if (a == -1 || b == -1) // non negative
                throw new NegativeInputException("Provide positive input only");

            // save the result into file
            //CalculatorRepo repo = new CalculatorRepo();
            repo.Save($"{a} + {b} = {a + b}");
            return a + b;
        }

        public int Subtract(int no1, int no2)
        {
            if (no1 == 0 || no2 == 0)
                throw new ZeroInputException("Provide non-zero input only");

            //CalculatorRepo repo = new CalculatorRepo();
            repo.Save($"{no1} - {no2} = {no1 - no2}");
            return no1 - no2;
        }
    }

    public interface ICalculatorRepo
    {
        void Save(string s);
    }

    public class CalculatorRepo : ICalculatorRepo // DAL
    {
        public void Save(string result)
        {
            File.WriteAllText("D:\\calcresult.txt", result);
        }
    }
}
