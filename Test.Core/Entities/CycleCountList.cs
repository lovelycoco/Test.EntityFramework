using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 盘库记录
    /// </summary>
    public class CycleCountList : BaseEntityOfGuid
    {
        /// <summary>
        /// 盘库记录
        /// </summary>
        public virtual Guid CycleCountId { get; set; }
        /// <summary>
        /// 盘库信息
        /// </summary>
        public virtual CycleCount CycleCount { get; set; }
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
