using System.Xml.Linq;

namespace LinqToXml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XDocument xml = XDocument.Load("books.xml");
            // select only book titles and display

            var titles = from book in xml.Descendants("title")
                         select book.Value;
            // select book titles and author names
            var titlesAndAuthors = from book in xml.Descendants("book")

                                   where double.Parse(book.Element("price").Value) >= 5.0

                                   select new
                                   {
                                       Title = book.Element("title").Value,
                                       Author = book.Element("author").Value,
                                       Price = double.Parse(book.Element("price").Value)
                                   };



            // display

            foreach (var data in titlesAndAuthors)
            {
                Console.WriteLine(data.Title + " - " + data.Author + " - " + data.Price);
            }
        }
    }

    //class TitleAuthor
    //{
    //    public string Title { get; set; }
    //    public string Author { get; set; }
    //    public double Price { get; set; }
    //}
}
