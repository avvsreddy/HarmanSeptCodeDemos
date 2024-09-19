namespace LinqDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Linq to Objects : Inmemory Data

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // extract all even numbers into separate collection then display
            // table: numbers
            // col: nunber
            // sql select: select number from numbers where number mod 2 = 0
            // old
            List<int> evens = new List<int>();

            foreach (int i in list)
            {
                if (i % 2 == 0)
                {
                    evens.Add(i);
                }
            }
            Console.WriteLine("Old way");
            foreach (int i in evens)
                Console.WriteLine(i);
            Console.WriteLine("=========");
            // sql select: select number from numbers where number mod 2 = 0
            // linq expression - keywords

            var evenNumbers = from i in list where i % 2 == 0 select i;

            // linq extensions

            var evenNumbers2 = list.Where(n => n % 2 == 0).Select(n => n);

            Console.WriteLine("Linq way");
            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
