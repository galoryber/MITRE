using System;
using System.Diagnostics;

namespace T1010_ApplicationWindowDiscovery
{
    class T1010
    {
        static void Main(string[] args)
        {
            var RunningProcs = System.Diagnostics.Process.GetProcesses();

            Console.WriteLine("---------- T1010 Application Window Discovery ----------");
            Console.WriteLine("");

            foreach (Process TitledProcess in RunningProcs)
            {
                if (TitledProcess.MainWindowTitle.ToString() != "")
                {
                    Process T1010Processes = TitledProcess;
                    var ID = T1010Processes.Id;
                    var Name = T1010Processes.ProcessName;
                    var Title = T1010Processes.MainWindowTitle;
                    Console.WriteLine("++++++++++");
                    Console.WriteLine(string.Format("Process Name : {0}", Name));
                    Console.WriteLine("     " + Title);
                    Console.WriteLine("");
                }
            }
        }
    }
}
