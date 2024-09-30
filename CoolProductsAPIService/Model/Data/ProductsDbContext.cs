using CoolProductsAPIService.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoolProductsAPIService.Model.Data
{
    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
