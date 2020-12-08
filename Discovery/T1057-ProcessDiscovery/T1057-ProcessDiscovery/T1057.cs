using System;
using System.Diagnostics; 

namespace T1057_ProcessDiscovery
{
    class T1057
    {
        static void Main(string[] args)
        {
            var RunningProcs = System.Diagnostics.Process.GetProcesses();

            Console.WriteLine("---------- T1057 Process Discovery ----------");
            Console.WriteLine("");

            foreach (Process proc in RunningProcs) 
            {
                var ProcName = proc.ProcessName;
                var ProcID = proc.Id;
                //var ProcTitle = proc.MainWindowTitle; //Application Window Discovery - T1010 - When available 
                //Console.WriteLine("{0} -- {1} -- {2}",ProcID,ProcName,ProcTitle);
                Console.WriteLine(string.Format("{0,10}|{1,40}", ProcID, ProcName)); 
            }

        }
    }
}
