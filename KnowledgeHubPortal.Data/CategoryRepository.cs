using KnowledgeHubPortal.Domain.Entities;
using KnowledgeHubPortal.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace KnowledgeHubPortal.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly KnowledgeHubPortalDbContext _context = null;
        public CategoryRepository(KnowledgeHubPortalDbContext context)
        {
            this._context = context;
        }
        public void Create(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();

        }

        public async Task CreateAsync(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public async Task<List<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
