namespace DelegatesDemo
{

    //class MyDelegate : Delegate
    //{

    //}
    //1. Declare the delegate
    delegate void MyDelegate(string str);
    delegate int MyDelegate2(string str);
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. direct - invoke by name

            //A. Name of the method
            //B. Singnature of the method
            //C. type of the method
            //c1. access specifier
            //D. Which class?
            //E. Which namespace
            //F. Which assembly



            //Greeting("calling directly");



            //2. indirect - invoke by addresss
            // delegate
            // sign + address

            //1. Declare the delegate
            //Delegate d = new Delegate();

            //2. Instantiation
            MyDelegate d = new MyDelegate(Program.Greeting);
            Program p = new Program();
            d += p.Hello; // subscription
            d -= Greeting; // Unsubscription
            d += Greeting;
            //3. Initialization
            //5. Invoke
            //d.Invoke("calling indirectly from delegate");
            d("calling indirectly from delegate");

        }



        static void Greeting(string msg)
        {
            Console.WriteLine($"Greeting: {msg}");
        }

        void Hello(string msg)
        {
            Console.WriteLine($"Hello: {msg}");
            return 0;
        }
    }
}
