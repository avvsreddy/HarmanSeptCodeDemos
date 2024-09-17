namespace CompanyOrdersLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();

            Customer c1 = new Customer();
            Customer c2 = new Customer();

            company.Customers.Add(c1);
            company.Customers.Add(c2);

            RegCustomer rc1 = new RegCustomer();
            RegCustomer rc2 = new RegCustomer();

            company.Customers.Add(rc1);
            company.Customers.Add(rc2);

            Console.WriteLine($"No. Of All Customer in a Company : {company.Customers.Count}");
            Console.WriteLine($"No. Of Normal Customer in a Company : {company.Customers.Count}");// Lab
            Console.WriteLine($"No. Of Reg. Customer in a Company : {company.Customers.Count}");// Lab


            Order order1 = new Order();
            c1.Orders.Add(order1);

            OrderedItem oi1 = new OrderedItem();


            Item i1 = new Item { Desc = "IPhone", Rate = 75000 };
            oi1.Item = i1;
            oi1.Quantity = 2;

            Item i2 = new Item { Desc = "Galaxy Watch", Rate = 35000 };
            OrderedItem oi2 = new OrderedItem { Quantity = 5, Item = i2 };

            order1.OrderedItems.Add(oi1);
            order1.OrderedItems.Add(oi2);

            Console.WriteLine($"Total Worth of orders: {company.GetTotalWorthOfOrdersPlaced()}");
        }
    }

    class Company
    {

        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Item> Items { get; set; } = new List<Item>();
        public double GetTotalWorthOfOrdersPlaced()
        {
            double total = 0;
            // TODO

            return total;
        }
    }
    class Item
    {
        public string Desc { get; set; }
        //private string _desc;
        //public string GetDesc() { return _desc; }
        //public void SetDesc(string desc) { _desc = desc; }

        public double Rate { get; set; }
    }
    class Customer
    {
        public List<Order> Orders { get; set; } = new List<Order>();
    }


    class RegCustomer : Customer // Is-A 
    {
        public double SplDiscount { get; set; }
    }
    class Order
    {
        public List<OrderedItem> OrderedItems { get; set; } = new List<OrderedItem>();
    }

    class OrderedItem
    {
        public Item Item { get; set; }
        public int Quantity { get; set; }
    }
}
