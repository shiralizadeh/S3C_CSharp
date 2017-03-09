using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3C_CSharp.Utilities
{
    delegate void Add(int a, string b);

    class Utility
    {
        public void Test()
        {
            Action s1 = () => { };
            Action<int> s2 = (int a) => { };
            Action<int, string> s3 = (a, b) => { };

            Func<int> f1 = () => { return 1; };
            Func<int, string> f2 = (a) => { return "1"; };
            Func<int, string, bool> f3 = (a, b) => { return false; };
            Func<int, string, bool> f4 = (a, b) => false;
        }
    }
}
