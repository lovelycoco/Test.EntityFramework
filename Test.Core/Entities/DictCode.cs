using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 数据字典
    /// </summary>
    public class DictCode : BaseEntityOfGuid
    {
        public virtual string DictType { get; set; }
        public virtual string TypeName { get; set; }

        public DictCode()
        {

        }
    }
}
