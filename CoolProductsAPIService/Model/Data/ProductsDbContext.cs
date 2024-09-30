using CoolProductsAPIService.Model.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoolProductsAPIService.Model.Data
{
    public class ProductsDbContext : IdentityDbContext<IdentityUser>
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
