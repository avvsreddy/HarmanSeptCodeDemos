using KnowledgeHubPortal.Domain.Entities;

namespace KnowledgeHubPortal.Domain.Repositories
{
    public interface IArticlesRepository
    {
        void Submit(Article article);
        List<Article> GetArticlesForBrowse(int categoryId);
        List<Article> GetArticlesForReview(int categoryId);

        void ApproveArticles(List<int> articleIds);
        void RejectArticles(List<int> articleIds);
    }
}
