using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProductsManagementApp.Entities;

namespace ProductsManagementApp.Data
{
    // to map db and tables with entity classess
    public class ProductsDbContext : DbContext
    {

        // configure and map to db server

        //1. using constructor
        //2. overriding onconfiguration method

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connStr1 = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=HarmanProductsDb2024;Integrated Security=True";
            string connStr2 = "Server=(localdb)\\mssqllocaldb;Database=HarmanProductsDb2024;Integrated Security=true";
            optionsBuilder.UseSqlServer(connStr1)
                .LogTo(Console.WriteLine, LogLevel.Information);

        }


        // configure and map entity classess with tables
        public DbSet<Product> Products { get; set; }

    }
}
