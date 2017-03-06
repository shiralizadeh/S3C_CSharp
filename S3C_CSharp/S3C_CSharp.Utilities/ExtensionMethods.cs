using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S3C_CSharp.Utilities
{
    public static class ExtensionMethods
    {
        public static string ToShamsi(this DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();

            var year = pc.GetYear(date);
            var month = pc.GetMonth(date);
            var day = pc.GetDayOfMonth(date);

            return year + "/" + month + "/" + day;
        }

        public static string SpaceOutCamelCasing(this string theWord)
        {
            char[] temp = theWord.ToCharArray();
            string Result = "";

            foreach (char c in temp)
                if (c.ToString() == c.ToString().ToUpper())
                    Result += " " + c;
                else
                    Result += c;

            return Result;
        }

        public static void ToFullScreen(this Form form, int screen = 0)
        {
            form.WindowState = FormWindowState.Maximized;
            form.StartPosition = FormStartPosition.Manual;
            form.Bounds = Screen.AllScreens[screen].Bounds;
        }
    }
}
