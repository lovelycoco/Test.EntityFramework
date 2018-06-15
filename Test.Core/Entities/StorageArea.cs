using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 库区
    /// </summary>
    public class StorageArea : BaseEntityOfGuid
    {
        public virtual int AreaCode { get; set; }
        public virtual int AreaType { get; set; }

    }
}
