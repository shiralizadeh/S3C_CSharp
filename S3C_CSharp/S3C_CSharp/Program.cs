using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace S3C_CSharp
{
    static class Program
    {
        //[DllImport()]
        //public extern static string test();

        //public volatile int MyProperty;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var t1 = new Thread(new ParameterizedThreadStart(Program.MyFunc));

            t1.Start("Ali");
            t1.Start("Mohamad");



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dates());
            Math.Pow(10, 2);
        }

        public static void MyFunc(object a)
        {
            Thread.Sleep(1000);
            "Start".Dump();
            Thread.Sleep(2000);
            "End".Dump();
            a.Dump();
        }
    }
}
