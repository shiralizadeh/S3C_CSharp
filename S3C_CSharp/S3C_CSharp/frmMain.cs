using S3C_CSharp.Models;
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

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            var foo = new Product()
            {
                Count = 10,
                Buyers = new ProductBuyer[6],
                Title = "Phone",
            };

            var vv = (ViewProduct)foo;

            long w = (long)foo;
            //long y = foo as long;

            var bar = new Product()
            {
                Count = 3,
                Buyers = new ProductBuyer[6],
                Title = "Car",
            };

            long test1 = foo + bar;
            Product test2 = foo + 60;

            test2 = (Product)foo.Clone();

            var a = (test2.Equals(foo));
            var b = (test2 == foo);

            var isExits = Convert.ToBoolean(foo, null);

            foo.SetTitle("My Title");

            byte bb = foo.Rate;
            foo.Rate = 12;
            foo.Rate = 10;
            foo.Rate = 5;
            foo.Rate = 25;

            foo.Count = 25;
            foo.Count = 0;

            //foo.rate = 255;

            foo.Buyers[0] = new ProductBuyer()
            {
                Name = "Ali",
                Count = 12
            };

            foo.Buyers[1] = new ProductBuyer()
            {
                Name = "Mohamad",
                Count = 5
            };

            foo.AddCount(10);
            foo.AddCount(5, "123");


            var f = foo["Mohamad"];

            "".ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var s = default(int);

            var test = new ListManager<Product, long>();

            test.Add(new Product() { Title = "A" });
            test.Add(new Product() { Title = "B" });
            test.Add(new Product() { Title = "C" });

            test.Count.ToString();

            var userManager = new ListManager<User, int>();

            userManager.Add(new User() { Username = "A" });
            userManager.Add(new User() { Username = "B" });
            userManager.Add(new User() { Username = "C" });

            try
            {

            }
            catch (Exception ex)
            {
                //Log("Count " + nameof(test) + ": " + test.GetCount());
                //Log("Count productManager: " + test.GetCount());
                throw;
            }

        }
    }

    class MyClass : ListManager<Product, long>
    {
        public override void Add(Product product)
        {
            base.list[base.index++ + 2] = product;
            base.Add(product);
        }
    }
}
