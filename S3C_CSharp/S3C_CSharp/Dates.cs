using S3C_CSharp;
using S3C_CSharp.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S3C_CSharp
{
    [Role("Accounting")]
    public partial class Dates : Form
    {
        public Dates()
        {
            InitializeComponent();
        }

        private void Dates_Load(object sender, EventArgs e)
        {
            this.ToFullScreen();

            var date = DateTime.Now;

            //textBox1.Text = date.ToShamsi();

            //textBox1.Text = "cameCase".SpaceOutCamelCasing();
        }

        public void Clear()
        {
            textBox1.Text = "";
        }
       
    }
}
