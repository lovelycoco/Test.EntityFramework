using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 备货单
    /// </summary>
    public class PickingList:BaseEntityOfGuid
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual string PickingListNo { get; set; }
    }
}
