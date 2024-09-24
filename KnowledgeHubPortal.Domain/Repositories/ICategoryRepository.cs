using KnowledgeHubPortal.Domain.Entities;

namespace KnowledgeHubPortal.Domain.Repositories
{
    public interface ICategoryRepository
    {
        void Create(Category category);
        List<Category> GetAll();
    }
}
