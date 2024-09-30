namespace CoolProductsClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // fetch all products from api service and display

            // discover the api uri
            string apiUri = "https://localhost:44368/api/Products";

            // GET all data
            HttpClient client = new HttpClient();
            var result = client.GetAsync(apiUri).Result;
            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var data = result.Content.ReadAsStringAsync().Result;
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine(result.StatusCode.ToString());
            }

        }
    }
}
