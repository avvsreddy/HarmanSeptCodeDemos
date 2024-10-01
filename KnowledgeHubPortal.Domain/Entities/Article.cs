namespace KnowledgeHubPortal.Domain.Entities
{
    public class Article
    {
        public int ArticleID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PostedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string ArticleUrl { get; set; }
        public bool IsApproved { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
