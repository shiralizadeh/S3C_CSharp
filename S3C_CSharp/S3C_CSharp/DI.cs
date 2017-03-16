using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3C_CSharp
{
    public interface IBar
    {
        int Count { get; set; }
    }

    public class Bar : IBar
    {
        public int Count { get; set; }
    }

    public interface ITest
    {
    }

    public class Test : ITest
    {
    }

    public interface IFoo
    {
    }

    public class Foo : IFoo
    {
        public IBar Bar { get; private set; }
        public ITest Test { get; private set; }

        public Foo(IBar bar, ITest test)
        {
            Bar = bar;
            Test = test;
        }
    }

}
