using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    public class DictCode : BaseEntityOfGuid
    {
        public virtual string DictType { get; set; }

        public DictCode()
        {
            
        }
    }
}
