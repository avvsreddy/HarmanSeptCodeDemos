using System.Configuration;

namespace POSApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaxCalculatorFactory factory1 = TaxCalculatorFactory.Instance;
            Console.WriteLine(factory1.GetHashCode());

            TaxCalculatorFactory factory2 = TaxCalculatorFactory.Instance;
            Console.WriteLine(factory2.GetHashCode());
            BillingSys billingSys = new BillingSys(factory1.Create());
            billingSys.GenerateBill();
        }
    }

    public class TaxCalculatorFactory
    {

        private TaxCalculatorFactory()
        {

        }
        public readonly static TaxCalculatorFactory Instance = new TaxCalculatorFactory();
        //public static TaxCalculatorFactory GetInstance()
        //{
        //    if (instance == null)
        //        instance = new TaxCalculatorFactory();


        //    return instance;
        //}
        virtual public ITaxCalculatorStrategy Create()
        {
            // read the config
            string calcClassName = ConfigurationManager.AppSettings["CALC"];
            // Reflextion
            Type theType = Type.GetType(calcClassName);

            // instantiate
            return (ITaxCalculatorStrategy)Activator.CreateInstance(theType);


            //return new KATaxCalculator();
        }
    }

    public class BillingSys
    {
        private ITaxCalculatorStrategy strategy;// = new TNTaxCalculator();

        public BillingSys(ITaxCalculatorStrategy strategy)
        {
            this.strategy = strategy;
        }
        public void GenerateBill()
        {
            // get all products by scanning
            // calculates any discounts
            // calculates any promo/coupons
            // calculate bill amount
            double billAmt = 5600.90;
            //TaxCalculator taxCalculator = new TaxCalculator();
            double taxAmt = strategy.CalculateTax(billAmt);
            double totalAmt = billAmt + taxAmt;
            // calculate tax amount
            // payment module
            // print the bill

        }
    }

    public interface ITaxCalculatorStrategy
    {
        double CalculateTax(double amt);
    }

    public class KATaxCalculator : ITaxCalculatorStrategy
    {
        public double CalculateTax(double amt)
        {
            // KA
            int cst = 100;
            int kst = 90;
            int sbt = 50;
            int kkt = 60;
            int abc = 40;
            int tax = cst + kst + sbt + kkt + abc;
            Console.WriteLine("Using KA Tax Calculator");
            return tax;
        }
    }

    public class TNTaxCalculator : ITaxCalculatorStrategy
    {
        public double CalculateTax(double amt)
        {

            int cst = 100;
            int tst = 96;
            //int sbt = 50;
            int xyz = 40;
            int kkt = 60;
            int abc = 40;
            int tax = cst + tst + xyz + kkt + abc;
            Console.WriteLine("Using TN Tax Calculator");

            return tax;


        }
    }

    // ustax.dll
    public class USTaxCalculator
    {
        public float ComputeTax(float amt)
        {
            return 234;
        }
    }

    public class USTaxCalculatorAdaptor : ITaxCalculatorStrategy
    {
        public double CalculateTax(double amt)
        {
            USTaxCalculator calc = new USTaxCalculator();
            Console.WriteLine("Using US Tax Calculator");
            return calc.ComputeTax((float)amt);
        }
    }
}
