namespace LinqToObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // select all product names only

            var products = from p in Data.GetProducts()
                           where p.Price <= 100
                           select new { PName = p.Name, Rate = p.Price, CName = p.Category.Name };

            foreach (var p in products)
            {
                //Console.WriteLine(p.PName + " " + p.Rate + " " + p.CName);
            }

            // total amount
            var total = (from p in Data.GetProducts()
                         select p.Price).Sum();
            Console.WriteLine($"Total Amount {total}");

            var productsInStock = (from p in Data.GetProducts()
                                   where p.InStock
                                   select p).Count();

            // get all products in assending order of price
            var allProducts = from p in Data.GetProducts()
                              orderby p.Price descending
                              select p;

            // get costliest product name
            var costliest = (from p in Data.GetProducts()
                             orderby p.Price
                             select p.Name).FirstOrDefault();

            Console.WriteLine(costliest.ToString());

        }
    }


    class Data
    {
        static public List<Product> GetProducts()
        {
            List<Category> categories = new List<Category>
            {
                new Category { Id = 1, Name = "Electronics" },
                new Category { Id = 2, Name = "Home Appliances" },
                new Category { Id = 3, Name = "Books" },
                new Category { Id = 4, Name = "Clothing" }
            };

            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Smartphone", Price = 699, InStock = true, Brand = "BrandA", Category = categories[0] },
                new Product { Id = 2, Name = "Laptop", Price = 999, InStock = true, Brand = "BrandB", Category = categories[0] },
                new Product { Id = 3, Name = "Microwave Oven", Price = 150, InStock = false, Brand = "BrandC", Category = categories[1] },
                new Product { Id = 4, Name = "Refrigerator", Price = 1200, InStock = true, Brand = "BrandD", Category = categories[1] },
                new Product { Id = 5, Name = "Science Fiction Book", Price = 25, InStock = true, Brand = "BrandE", Category = categories[2] },
                new Product { Id = 6, Name = "Fantasy Book", Price = 30, InStock = false, Brand = "BrandF", Category = categories[2] },
                new Product { Id = 7, Name = "T-Shirt", Price = 20, InStock = true, Brand = "BrandG", Category = categories[3] },
                new Product { Id = 8, Name = "Jeans", Price = 50, InStock = true, Brand = "BrandH", Category = categories[3] }
            };
            return products;
        }
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool InStock { get; set; }
        public Category Category { get; set; }

        public string Brand { get; set; }
    }

    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
