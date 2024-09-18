namespace DelegatesDemo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account();
            //acc1.Balance = 1000;
            acc1.Notify += Notification.SendMail; //sub
            acc1.Notify += Notification.SendSMS;// sub
            //acc1.Notify -= Notification.SendMail; //unsub
            acc1.Notify += Notification.SendWhatsApp;//sub
            acc1.Deposit(1000);
            //acc1.Notify("Your account has been increased by $9999999999999999");
            Console.WriteLine(acc1.Balance);
            acc1.Withdraw(100);
            //Console.WriteLine(acc1.Balance);
        }
    }


    class Account // SRP OCP
    {
        public int Balance { get; private set; }
        public event NotificationDelegate Notify;

        public void Deposit(int amount) //SRP
        {
            Balance += amount;
            // send email
            //Notification.SendMail();
            //Notification.SendSMS();
            if (Notify != null)
            {
                Notify($"Your account has been deposited by {amount}");
            }

        }

        public void Withdraw(int amount)
        {
            Balance -= amount;
            // send email code
            //Notification.SendMail();
            //Notification.SendSMS();
            if (Notify != null)
            {
                Notify($"Your account has been decreased by {amount}");
            }
        }


    }
    public delegate void NotificationDelegate(string msg);

    class Notification
    {
        public static void SendMail(string msg)
        {
            Console.WriteLine($"EMail: {msg}");
        }

        public static void SendSMS(string msg)
        {
            Console.WriteLine($"SMS: {msg}");
        }
        public static void SendWhatsApp(string msg)
        {
            Console.WriteLine($"WhatsApp: {msg}");
        }
    }
}
