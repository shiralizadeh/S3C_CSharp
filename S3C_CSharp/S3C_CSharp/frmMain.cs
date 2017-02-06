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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAlert_Click(object sender, EventArgs e)
        {
            int a = -1,
                b = 20,
                c = 30,
                sum = -1,
                sum2 = -1;

            var isSuccess = int.TryParse(txtInput.Text, out a);

            if (isSuccess == true)
            {
                sum = Sum(a, ref b, out sum2, num4: 60);

                sum = Sum2(1, 2, 3, 4, 654, 65, 6, 65, 65, 65, 6);

                MessageBox.Show(sum.ToString());

                MessageBox.Show(sum2.ToString());
            }
            else
            {
                MessageBox.Show("خودتی!!");
            }
        }

        int Sum(int num1, ref int num2, out int sum2, int num3 = 12, int num4 = 25)
        {
            num2 = 50;

            sum2 = num1 + num2;

            return num1 + num2 + num3;
        }

        int Sum2(params int[] inputs)
        {
            int result = 0;

            foreach (var item in inputs)
            {
                result = result + item;
            }

            return result;
        }

        void Sum3(params int[] inputs)
        {
            if (true)
            {
                return;
            }

            "".ToString();
        }
    }
}
