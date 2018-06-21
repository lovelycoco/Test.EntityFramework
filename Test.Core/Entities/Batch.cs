using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 物料批次表
    /// </summary>
    public class Batch : BaseEntityOfGuid
    {
        /// <summary>
        /// 批次编号
        /// </summary>
        public virtual string BatchNum { get; set; }
        /// <summary>
        /// 生产日期
        /// </summary>
        public virtual DateTime? ProductionDate { get; set; }
        /// <summary>
        /// 是否冻结
        /// </summary>
        public virtual bool IsBlocked { get; set; }
        /// <summary>
        /// 封存时间
        /// </summary>
        public virtual DateTime? BlockedTime { get; set; }

        public Batch()
        {
            IsBlocked = false;
        }
    }
}
