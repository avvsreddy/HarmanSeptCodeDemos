using System.Diagnostics;

namespace DelegatesDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // client 1 - list all running proc names
            ProcessManager.ShowProcessList(NoFilter);

            // client 2 - display only proc sw S
            //ProcessManager.ShowProcessList(FilterByName);

            //client 3 - display proce mem size > 50MB
            //FilterDelegate filter = new FilterDelegate(FilterByMemSize);
            //ProcessManager.ShowProcessList(filter);
        }
        // client 1

        static bool NoFilter(Process process) { return true; }


        //client 2
        static bool FilterByName(Process p)
        {
            return p.ProcessName.StartsWith("S");
        }


        // client 3
        static bool FilterByMemSize(Process p)
        {
            return p.WorkingSet64 >= 500 * 1024 * 1024;
        }
    }



    // backend dev

    public delegate bool FilterDelegate(Process process);
    class ProcessManager
    {
        public static void ShowProcessList(FilterDelegate filter)
        {
            foreach (Process p in Process.GetProcesses())
            {
                if (filter(p))
                    Console.WriteLine(p.ProcessName);
            }
        }
        //public static void ShowProcessList(string sw)
        //{
        //    foreach (Process p in Process.GetProcesses())
        //    {
        //        if (p.ProcessName.StartsWith(sw))
        //            Console.WriteLine(p.ProcessName);
        //    }
        //}

        //public static void ShowProcessList(long size)
        //{
        //    foreach (Process p in Process.GetProcesses())
        //    {
        //        if (p.WorkingSet64 >= size)
        //            Console.WriteLine(p.ProcessName);
        //    }
        //}
    }
}
