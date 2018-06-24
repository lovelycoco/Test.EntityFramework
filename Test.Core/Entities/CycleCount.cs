using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 盘点表
    /// </summary>
    public class CycleCount : BaseEntityOfOperator
    {
        /// <summary>
        /// 盘库类型Id
        /// </summary>
        public virtual Guid DataDictionaryInfoId { get; set; }
        /// <summary>
        /// 盘库类型
        /// </summary>
        public virtual DataDictionaryInfo CountType { get; set; }
        /// <summary>
        /// 库位Id
        /// </summary>
        public virtual Guid StorageBinId { get; set; }
        /// <summary>
        /// 库位
        /// </summary>
        public virtual StorageBin StorageBin { get; set; }
        /// <summary>
        /// 总数量
        /// </summary>
        public virtual int TotalQuantity { get; set; }
        /// <summary>
        /// 丢失数量
        /// </summary>
        public virtual int LostQuantity { get; set; }
        /// <summary>
        /// 情况说明
        /// </summary>
        public virtual string Memo { get; set; }
        /// <summary>
        /// 是否目视盘库
        /// </summary>
        public virtual bool IsVisual { get; set; }
        public CycleCount()
        {
            IsVisual = false;
        }
    }
}
