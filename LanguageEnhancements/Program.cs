namespace LanguageEnhancements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. local variable type inference
            // 2. Object Initialization Syntax
            // 3. Anonymous Types
            // 4. Extension Methods
            // 5. Lambda


            //var i = 10;


            string data = "confidential data";
            data.ToUpper();
            data.Encrypt("MD5");
            data = Security.Encrypt(data, "SHA256");
            string str = "sdfsdfsd";
            //str.Encrypt();
            int i = 100;
            //.Encrypt();
            Program p = new Program();
            //p.en

            int[] numbers = new int[10];


            List<int> list = new List<int>();



        }
    }



    static class Security
    {
        public static string Encrypt(this string data, string encType)
        {
            return "@#$@#$SDFFG@#$@#%ERGETY#$@#%@#%@#%";
        }
    }


    //class Person
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public int Salary { get; set; }
    //}

    class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        //public Item()
        //{

        //}
        //public Item(int id)
        //{
        //    this.Id = id;
        //}
        //public Item(int id, string name):this(id)
        //{
        //    //this.Id = id;
        //    this.Name = name;
        //}
        //public Item(int id, string name, int price):this(id,name)
        //{
        //    //this.Id = id;
        //    this.Price = price;
        //    //this.Name = name;
        //}
    }
}
