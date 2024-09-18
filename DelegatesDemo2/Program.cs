using System.Diagnostics;

namespace DelegatesDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // client 1 - list all running proc names
            //ProcessManager.ShowProcessList();

            // client 2 - display only proc sw S
            //ProcessManager.ShowProcessList("S");

            //client 3 - display proce mem size > 50MB
            ProcessManager.ShowProcessList(500 * 1024 * 1024);
        }
    }



    // backend dev
    class ProcessManager
    {
        public static void ShowProcessList()
        {
            foreach (Process p in Process.GetProcesses())
            {
                Console.WriteLine(p.ProcessName);
            }
        }
        public static void ShowProcessList(string sw)
        {
            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName.StartsWith(sw))
                    Console.WriteLine(p.ProcessName);
            }
        }

        public static void ShowProcessList(long size)
        {
            foreach (Process p in Process.GetProcesses())
            {
                if (p.WorkingSet64 >= size)
                    Console.WriteLine(p.ProcessName);
            }
        }
    }
}
