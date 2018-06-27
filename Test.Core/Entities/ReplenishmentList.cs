using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 补货单记录
    /// </summary>
    public class ReplenishmentList:BaseEntityOfGuid
    {
        /// <summary>
        /// 补货单Id
        /// </summary>
        public virtual Guid ReplenishmentId { get; set; }
        /// <summary>
        /// 补货单信息
        /// </summary>
        public virtual Replenishment  Replenishment { get; set; }
        /// <summary>
        /// 器具Id
        /// </summary>
        public virtual Guid BoxId { get; set; }
        /// <summary>
        /// 器具信息
        /// </summary>
        public virtual Box Box { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public virtual int Quantity { get; set; }
    }
}
