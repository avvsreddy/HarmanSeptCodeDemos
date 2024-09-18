namespace DeletesDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };

            // find evens sum

            int evensSum = 0;

            foreach (int i in list)
            {
                if (i % 2 == 0)
                {
                    evensSum += i;
                }
            }

            // fw
            Func<int, bool> filter = new Func<int, bool>(IsEven);
            evensSum = list.Where(filter).Sum();

            evensSum = list.Where(IsEven).Sum();

            // Anonymous

            evensSum = list.Where(delegate (int x)
            {
                return x % 2 == 0;
            }).Sum();

            // Lambda statement

            evensSum = list.Where((int x) =>
            {
                return x % 2 == 0;
            }).Sum();

            // Lambda expression

            evensSum = list.Where(x => x % 2 == 0).Sum();
        }

        static bool IsEven(int x)
        {
            return x % 2 == 0;
        }
    }
}
