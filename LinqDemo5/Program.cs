using System.Xml.Linq;

namespace LinqDemo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "one", "two", "three", "four", "five", "six" };

            // Linq To Object
            // select all short words from the list of words then display
            var shortWords = from word in words
                             where word.Length <= 3
                             select word;
            foreach (var word in shortWords) { Console.WriteLine(word); }

            // Linq to XML
            // load xml document into memory
            Console.WriteLine("From XML");
            XDocument xml = XDocument.Load("words.xml");

            var shortWords2 = from word in xml.Descendants("word")
                              where word.Value.Length <= 3
                              select word.Value;
            foreach (var word in shortWords2) { Console.WriteLine(word); }

        }
    }
}
