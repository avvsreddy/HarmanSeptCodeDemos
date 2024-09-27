using EFCore.BulkExtensions;
using KnowledgeHubPortal.Domain.Entities;
using KnowledgeHubPortal.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace KnowledgeHubPortal.Data
{
    public class ArticlesRepository : IArticlesRepository
    {
        private readonly KnowledgeHubPortalDbContext db;

        public ArticlesRepository(KnowledgeHubPortalDbContext db)
        {
            this.db = db;
        }
        public void ApproveArticles(List<int> articleIds)
        {
            var articlesToApprove = new List<Article>();
            foreach (var id in articleIds)
            {
                var articleToApprove = db.Articles.Find(id);
                articleToApprove.IsApproved = true;
                articlesToApprove.Add(articleToApprove);

            }

            db.BulkUpdate(articlesToApprove);
        }

        public async Task ApproveArticlesAsync(List<int> articleIds)
        {
            var articlesToApprove = new List<Article>();
            foreach (var id in articleIds)
            {
                var articleToApprove = db.Articles.Find(id);
                articleToApprove.IsApproved = true;
                articlesToApprove.Add(articleToApprove);

            }

            await db.BulkUpdateAsync(articlesToApprove);
        }

        public List<Article> GetArticlesForBrowse(int categoryId)
        {
            List<Article> articles = null;

            if (categoryId == 0)
            {
                articles = db.Articles.Where(a => a.IsApproved).ToList();
            }
            else
            {
                articles = db.Articles.Where(a => a.IsApproved && a.CategoryID == categoryId).ToList();
            }

            return articles;
        }

        public async Task<List<Article>> GetArticlesForBrowseAsync(int categoryId)
        {
            List<Article> articles = null;

            if (categoryId == 0)
            {
                articles = await db.Articles.Where(a => a.IsApproved).ToListAsync();
            }
            else
            {
                articles = await db.Articles.Where(a => a.IsApproved && a.CategoryID == categoryId).ToListAsync();
            }

            return articles;
        }

        public List<Article> GetArticlesForReview(int categoryId = 0)
        {
            List<Article> articles = null;

            if (categoryId == 0)
            {
                articles = db.Articles.Where(a => !a.IsApproved).ToList();
            }
            else
            {
                articles = db.Articles.Where(a => !a.IsApproved && a.CategoryID == categoryId).ToList();
            }

            return articles;

        }

        public async Task<List<Article>> GetArticlesForReviewAsync(int categoryId)
        {
            List<Article> articles = null;

            if (categoryId == 0)
            {
                articles = await db.Articles.Where(a => !a.IsApproved).ToListAsync();
            }
            else
            {
                articles = await db.Articles.Where(a => !a.IsApproved && a.CategoryID == categoryId).ToListAsync();
            }

            return articles;
        }

        public void RejectArticles(List<int> articleIds)
        {
            var articlesToRejectList = new List<Article>();
            foreach (var id in articleIds)
            {
                var articleToReject = db.Articles.Find(id);
                articlesToRejectList.Add(articleToReject);
                //db.Articles.Remove(articleToReject);
            }
            //db.SaveChanges();
            db.BulkDelete(articlesToRejectList);
        }

        public async Task RejectArticlesAsync(List<int> articleIds)
        {
            var articlesToRejectList = new List<Article>();
            foreach (var id in articleIds)
            {
                var articleToReject = db.Articles.Find(id);
                articlesToRejectList.Add(articleToReject);

            }

            await db.BulkDeleteAsync(articlesToRejectList);
        }

        public void Submit(Article article)
        {
            db.Articles.Add(article);
            db.SaveChanges();
        }

        public async Task SubmitAsync(Article article)
        {
            db.Articles.Add(article);
            await db.SaveChangesAsync();
        }
    }
}
