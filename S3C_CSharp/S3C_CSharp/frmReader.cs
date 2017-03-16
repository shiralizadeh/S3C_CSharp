using S3C_CSharp.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S3C_CSharp
{
    [Role("User")]
    public partial class frmReader : Form
    {
        public frmReader()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var req = HttpWebRequest.Create("http://tabnakfarhangi.ir/");

            var res = req.GetResponse();

            var sr = new StreamReader(res.GetResponseStream());

            var output = sr.ReadToEnd();

            Regex regex = new Regex("href=\"(\\/fa\\/news.+?)\"", RegexOptions.Multiline | RegexOptions.IgnoreCase);
            //Regex regex = new Regex("<h1.*?<a.*?>(.*?)<\\/a>");

            var matches = regex.Matches(output);

            int i = 0;
            foreach (Match item in matches)
            {
                richTextBox1.AppendText(getTitle("http://tabnakfarhangi.ir" + item.Groups[1].Value.Trim()) + "\n\r");

                this.PerformLayout();

            }
        }

        private string getTitle(string url)
        {
            var req = HttpWebRequest.Create(url);

            var res = req.GetResponse();

            var sr = new StreamReader(res.GetResponseStream());

            var output = sr.ReadToEnd();

            Regex regex = new Regex("<h1.*?<a.*?>(.*?)<\\/a>");

            var match = regex.Match(output);

            return match.Groups[1].Value;
        }
    }
}
