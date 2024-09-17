using CalculatorLibrary;
namespace ExceptionsDemo
{
    internal class Program // SRP - UI
    {

        static Calculator calc = new Calculator();
        static void Main(string[] args) // SRP
        {
            // accept two non-zero, positive, even   ints and find the sum then display ---- 

            int fno;
            int sno;
            int sum = 0;
            while (true)
            {
                try
                {

                    // open db connction
                    Console.Write("Enter First Number: ");
                    fno = int.Parse(Console.ReadLine());

                    Console.Write("Enter Second Number: ");
                    sno = int.Parse(Console.ReadLine());

                    // non-zero
                    sum = calc.FindSum(fno, sno);
                    Console.WriteLine($"The sum of {fno} and {sno} is {sum}");
                    // save to db
                    // close conn
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Enter only numbers");
                }
                //catch (OverflowException ex)
                //{
                //    Console.WriteLine("Enter small int numbers onl");
                //}
                catch (NonZeroNumberException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                // catch all  block
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                finally
                {
                    // allways exe 
                }
            }
            Console.WriteLine("End of the application");
        }
    }
}
