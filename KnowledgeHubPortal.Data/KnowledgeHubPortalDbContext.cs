using KnowledgeHubPortal.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace KnowledgeHubPortal.Data
{
    public class KnowledgeHubPortalDbContext : DbContext
    {
        public KnowledgeHubPortalDbContext()
        {

        }
        public KnowledgeHubPortalDbContext(DbContextOptions<KnowledgeHubPortalDbContext> options) : base(options)
        {
            // for configuring database from config file
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // for configuring database from hardcoded connection string
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=HarmanKHPDb2024;Integrated Security=True;MultipleActiveResultSets=True").UseLazyLoadingProxies().LogTo(Console.WriteLine, LogLevel.Information);
            }
        }

        // map the entities with tables
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}
