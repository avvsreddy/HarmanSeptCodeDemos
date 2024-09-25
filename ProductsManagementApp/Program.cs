using ProductsManagementApp.Data;
using ProductsManagementApp.Entities;

namespace ProductsManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Select();
        }

        private static void Delete()
        {
            // delete product id 1
            var db = new ProductsDbContext();
            // get the object for editing or deleting
            var productToDelete = db.Products.Find(1);
            if (productToDelete != null)
            {
                db.Products.Remove(productToDelete);
                db.SaveChanges();
            }
        }

        private static void Edit()
        {
            // for product id 1 change the price
            var db = new ProductsDbContext();
            // get the object for editing or deleting
            // use linq to entities
            //var productToEdit = (from product in db.Products
            //                     where product.ProductId == 1
            //                     select product).FirstOrDefault();

            var productToEdit = db.Products.Find(1);

            if (productToEdit != null)
            {
                productToEdit.Price += 1000;
            }

            db.SaveChanges();
        }

        private static void Select()
        {
            // get all products and display
            using (var db = new ProductsDbContext())
            {
                // use linq to Entities or ESql
                var allProducts = from p in db.Products
                                  select p;

                foreach (var product in allProducts)
                {
                    Console.WriteLine(product.Name);
                }

            }
        }

        private static void Add()
        {
            // Use Case: accept product details and save it.
            // Framework: EF core
            // Install the EF Core Framework
            //1. EF Core : done
            //2. Tools :done
            //3. Provider :done
            // Approach: Code First / DBFirst
            // Step 1: Create Entity Classes : done/ Create Database and tables
            // Step 2: Map Database and Tables with Entity Classes : Code First - done
            // Step 3: Do db migrations : creates and maps db and tables - done
            // Step 4: Perform CRUD operations

            // write only oo code
            Product product = new Product();
            //product.ProductId = 111;
            product.Name = "IPhone 16 Max Pro";
            product.Price = 89999;
            ProductsDbContext db = new ProductsDbContext();
            using (db)
            {
                db.Products.Add(product);
                //db.Database.ExecuteSqlRaw("");
                db.SaveChanges();
                Console.WriteLine("Product saved");
                //db.Dispose();
            }
            //
            //sdfsdfsdf
            //sdfsdfsdfsd
        }
    }
}
