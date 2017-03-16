using S3C_CSharp.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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
            //var t1 = new Thread(new ParameterizedThreadStart(Program.));

            //t1.Start("Ali");
            //t1.Start("Mohamad");

            //var stopw = new Stopwatch();
            //stopw.Start();

            //var sw = new StreamWriter(@"E:\1.txt");

            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < 10000000; i++)
            //{
            //    sb.Append(i.ToString());
            //}

            //sw.WriteLine(sb.ToString());
            //sw.Close();

            //stopw.Stop();

            //MessageBox.Show(stopw.ElapsedMilliseconds.ToString());

            //return;

            // login


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var fr = new frmDI();

            if (Program.CheckForm(fr))
            {
                Application.Run(fr);
            }

            Math.Pow(10, 2);
        }

        public static bool CheckForm(Form frm)
        {
            var user = new
            {
                Username = "Shiralizadeh",
                Roles = "User,Accounting"
            };

            var type = frm.GetType();
            var attributes = type.GetCustomAttributes(false);

            //var dd = (Form)Activator.CreateInstance(type);
            //dd.Show();

            if (type.GetMethods().Any(a => a.Name == "Clear"))
            {
                var method = type.GetMethod("Clear");

                method.Invoke(frm, null);
            }

            if (attributes.Any(item => item is FullScreenAttribute))
            {
                frm.ToFullScreen();
            }

            if (attributes.Any(item => item is RoleAttribute))
            {
                var role = (RoleAttribute)attributes.Single(item => item is RoleAttribute);

                if (role.Roles.Any(a => user.Roles.Split(',').Contains(a)))
                {
                    return true;
                }
            }

            

            return false;
        }

        //public static void MyFunc(object a)
        //{
        //    Thread.Sleep(1000);
        //    "Start".Dump();
        //    Thread.Sleep(2000);
        //    "End".Dump();
        //    a.Dump();
        //}
    }
}
