using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace my_service
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
           

#if DEBUG
            Service1 myservice = new Service1();
            myservice.ondebug();
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
        }
             private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
#else
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Service1()
            };
            ServiceBase.Run(ServicesToRun);
#endif

    }
    }

