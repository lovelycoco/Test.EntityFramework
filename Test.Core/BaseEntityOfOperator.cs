using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core
{
    /// <summary>
    /// 操作人员基类
    /// </summary>
    public class BaseEntityOfOperator:BaseEntityOfGuid
    {
        /// <summary>
        /// 操作员
        /// </summary>
        public virtual Guid Operator{ get; set; }
    }
}
