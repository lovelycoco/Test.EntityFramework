using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 账目表
    /// </summary>
    public class Accounts : BaseEntityOfOperator
    {
        /// <summary>
        /// 物料Id
        /// </summary>
        public virtual Guid MaterialId { get; set; }
        /// <summary>
        /// 物料信息
        /// </summary>
        public virtual Material Material { get; set; }
        /// <summary>
        /// 期初数
        /// </summary>
        public virtual int OpeningBalance { get; set; }
        /// <summary>
        /// 正常总数
        /// </summary>
        public virtual int NormalQuantity { get; set; }
        /// <summary>
        /// 仓储数量
        /// </summary>
        public virtual int StorageQuantity { get; set; }
        /// <summary>
        /// PC数量
        /// </summary>
        public virtual int PCQuantity { get; set; }
        /// <summary>
        /// 不良品数量
        /// </summary>
        public virtual int BadGoodsQuantity { get; set; }
        /// <summary>
        /// 预入库数量
        /// </summary>
        public virtual int PreEntryQuantity { get; set; }
        /// <summary>
        /// 虚拟数量
        /// </summary>
        public virtual int VirtualQuantity { get; set; }
        /// <summary>
        /// 封账时间
        /// </summary>
        public virtual DateTime? BlockedDate { get; set; }
    }
}
