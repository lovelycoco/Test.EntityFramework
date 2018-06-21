using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 物料记录表
    /// </summary>
    public class MaterialList : BaseEntityOfOperator
    {
        /// <summary>
        /// 交货单号
        /// </summary>
        public virtual string BillOrder { get; set; }
        /// <summary>
        /// 物料Id
        /// </summary>
        public virtual Guid MaterialId { get; set; }
        /// <summary>
        /// 物料信息
        /// </summary>
        public virtual Material Material { get; set; }
        /// <summary>
        /// 批次Id
        /// </summary>
        public virtual Guid BatchId { get; set; }
        /// <summary>
        /// 批次信息
        /// </summary>
        public virtual Batch Batch { get; set; }
        /// <summary>
        /// 到货日期
        /// </summary>
        public virtual DateTime ArrivalDate { get; set; }
        /// <summary>
        /// 物料数量
        /// </summary>
        public virtual int MaterialNum { get; set; }
        /// <summary>
        /// 字典信息Id
        /// </summary>
        public virtual Guid DataDictionaryInfoId { get; set; }
        /// <summary>
        /// 物料状态
        /// </summary>
        public virtual DataDictionaryInfo MaterialStatus { get; set; }
        public MaterialList()
        {
            ArrivalDate = DateTime.Now;
        }
    }
}
