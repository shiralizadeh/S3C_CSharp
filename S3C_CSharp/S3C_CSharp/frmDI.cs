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
    [Role("User")]
    public partial class frmDI : Form
    {
        public frmDI()
        {
            InitializeComponent();
        }

        private void frmDI_Load(object sender, EventArgs e)
        {
            var container = new StructureMap.Container(config =>
            {
                config.For<IBar>().Use<Bar>();
                config.For<IFoo>().Use<Foo>();
                config.For<ITest>().Use<Test>();
            });


            var f = (Foo)container.GetInstance<IFoo>();
            f.Bar.Count = 22;

            var w = (Foo)container.GetInstance<IFoo>();
            w.Bar.Count.ToString();

            f.ToString();
        }


    }
}
