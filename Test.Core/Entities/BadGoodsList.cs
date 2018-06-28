using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 不良品记录表
    /// </summary>
    public class BadGoodsList : BaseEntityOfOperator
    {
        /// <summary>
        /// 不良品Id
        /// </summary>
        public virtual Guid BadGoodsId { get; set; }
        /// <summary>
        /// 不良品信息
        /// </summary>
        public virtual BadGoods BadGoods { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public virtual int Quantity { get; set; }
        /// <summary>
        /// 返修单号
        /// </summary>
        public virtual string RepairNo { get; set; }
        /// <summary>
        /// 返修单图片
        /// </summary>
        public virtual byte[] RepairImage { get; set; }
        /// <summary>
        /// 操作类型Id
        /// </summary>
        public virtual Guid OperationTypeId { get; set; }
        /// <summary>
        /// 操作类型
        /// </summary>
        public virtual DataDictionaryInfo OperationType { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public virtual DateTime OperationDate { get; set; }
        /// <summary>
        /// 器具Id
        /// </summary>
        public virtual Guid? BoxId { get; set; }
        /// <summary>
        /// 器具信息
        /// </summary>
        public virtual Box Box { get; set; }
    }
}
