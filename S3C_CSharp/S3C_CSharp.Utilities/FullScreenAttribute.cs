using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3C_CSharp.Utilities
{
    [AttributeUsage(AttributeTargets.Class)]
    public class FullScreenAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class)]
    public class RoleAttribute : Attribute
    {
        public RoleAttribute(string roles)
        {
            this.Roles = roles.Split(',').ToList();
        }

        public List<string> Roles { get; set; }
    }
}
