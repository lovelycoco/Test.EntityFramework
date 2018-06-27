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
        /// 物料清单Id
        /// </summary>
        public virtual Guid BillOfMaterialId { get; set; }
        /// <summary>
        /// 物料清单
        /// </summary>
        public virtual BillofMaterial BillofMaterial { get; set; }
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
        public virtual int Quantity { get; set; }
        /// <summary>
        /// 物料状态Id
        /// </summary>
        public virtual Guid MaterialStatusId { get; set; }
        /// <summary>
        /// 物料状态
        /// </summary>
        public virtual DataDictionaryInfo MaterialStatus { get; set; }
        /// <summary>
        /// 标签信息
        /// </summary>
        //public virtual Tag Tag { get; set; }
        /// <summary>
        /// 追溯信息
        /// </summary>
        public virtual ICollection<Trace> Traces { get; }
        /// <summary>
        /// 器具
        /// </summary>
        public virtual Box Box { get; set; }
        public MaterialList()
        {
            ArrivalDate = DateTime.Now;
            Traces = new List<Trace>();
        }
    }
}
