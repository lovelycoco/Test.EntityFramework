using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field)]
    public class DBDescriptionAttribute : Attribute
    {
        public string Description { get; set; }

        public DBDescriptionAttribute(string description)
        {
            this.Description = description;
        }

    }
}
