namespace ContactManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbFirstDemoDbContext db = new DbFirstDemoDbContext();
            Contact c = new Contact { ContactName = "Sachin", City = "Mumbai", Email = "sachin@bcci.org", Mobile = "234234234" };

            db.Contacts.Add(c);
            db.SaveChanges();
        }
    }
}
