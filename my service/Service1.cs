using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace my_service
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }


        public void ondebug()
        {
            OnStart(null);
        }

        protected override void OnStart(string[] args)
        {
            System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "on start creted.text");
            //      System.Diagnostics.Process.Start(@"E:\PROJECT XL\INI SQLLOADER\ConsoleApplication2\ConsoleApplication2\ConsoleApplication2\bin\Debug\ConsoleApplication2.exe");
            System.Diagnostics.Process.Start(@"C:\HealthDiagnostic\timothy_test.exe");
        }

        protected override void OnStop()
        {
            System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "on stop creted.text");

        }

    }
}
