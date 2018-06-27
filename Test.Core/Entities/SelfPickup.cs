using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 自提表
    /// </summary>
    public class SelfPickup : BaseEntityOfOperator
    {
        /// <summary>
        /// 自提人
        /// </summary>
        public virtual string SelfPeople { get; set; }
        /// <summary>
        /// 自提时间
        /// </summary>
        public virtual DateTime SelfDate { get; set; }
        /// <summary>
        /// 供应商Id
        /// </summary>
        public virtual Guid SupplierId { get; set; }
        /// <summary>
        /// 供应商
        /// </summary>
        public virtual Supplier Supplier { get; set; }
        /// <summary>
        /// 是否打印
        /// </summary>
        public virtual bool IsPrinted { get; set; }
        /// <summary>
        /// 打印日期
        /// </summary>
        public virtual DateTime? PrintDate { get; set; }
        /// <summary>
        /// 自提来源Id
        /// </summary>
        public virtual Guid OriginalTypeId { get; set; }
        /// <summary>
        /// 自提来源
        /// </summary>
        public virtual DataDictionaryInfo OriginalType { get; set; }
        /// <summary>
        /// 自提记录
        /// </summary>
        public virtual ICollection<SelfPickupList> SelfPickupLists { get; set; }

        /// <summary>
        /// 出门证操作人Id
        /// </summary>
        public virtual Guid? OutCardUserId { get; set; }
        /// <summary>
        /// 出门证操作时间
        /// </summary>
        public virtual DateTime? OutCardDate { get; set; }
        /// <summary>
        /// 出门证是否打印
        /// </summary>
        public virtual bool IsOutCardPrinted { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public virtual string Memo  { get; set; }

        public SelfPickup()
        {
            SelfPickupLists = new List<SelfPickupList>();
            IsPrinted = false;
            IsOutCardPrinted = false;
        }
    }
}
