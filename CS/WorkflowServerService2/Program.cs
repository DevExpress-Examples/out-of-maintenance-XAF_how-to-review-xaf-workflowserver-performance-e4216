using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace WorkflowServerService2 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main() {
            Console.WriteLine("Starting...");
            WorkflowServerService2 service = new WorkflowServerService2();
            service.Start();
            Console.WriteLine("Started. Press Enter to stop.");
            Console.ReadLine();
            Console.WriteLine("Stopping...");
            service.Stop();
            Console.WriteLine("Stopped.");
        }
    }
}
