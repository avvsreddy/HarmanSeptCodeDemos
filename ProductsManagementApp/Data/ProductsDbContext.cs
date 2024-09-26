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
            string connStr1 = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=HarmanProductsDb2024;Integrated Security=True;MultipleActiveResultSets=True";
            string connStr2 = "Server=(localdb)\\mssqllocaldb;Database=HarmanProductsDb2024;Integrated Security=true;MultipleActiveResultSets=True";
            optionsBuilder.UseSqlServer(connStr1)
                .LogTo(Console.WriteLine, LogLevel.Information).UseLazyLoadingProxies();

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Person>().UseTphMappingStrategy();
            //modelBuilder.Entity<Person>().UseTptMappingStrategy();
            modelBuilder.Entity<Person>().UseTpcMappingStrategy();

        }


        // configure and map entity classess with tables
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Person> People { get; set; }

    }
}
