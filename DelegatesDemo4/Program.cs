namespace DelegatesDemo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account();
            //acc1.Balance = 1000;
            acc1.Deposit(1000);
            Console.WriteLine(acc1.Balance);
            acc1.Withdraw(100);
            Console.WriteLine(acc1.Balance);
        }
    }


    class Account // SRP OCP
    {
        public int Balance { get; private set; }


        public void Deposit(int amount) //SRP
        {
            Balance += amount;
            // send email
            Notification.SendMail();
            Notification.SendSMS();

        }

        public void Withdraw(int amount)
        {
            Balance -= amount;
            // send email code
            Notification.SendMail();
            Notification.SendSMS();
        }


    }


    class Notification
    {
        public static void SendMail()
        {
            Console.WriteLine("EMail: mail sent");
        }

        public static void SendSMS()
        {
            Console.WriteLine("SMS: sms sent");
        }
    }
}
