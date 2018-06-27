using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    public class Box : BaseEntityOfOperator
    {
        /// <summary>
        /// 器具编号
        /// </summary>
        public virtual string BoxNo { get; set; }
        /// <summary>
        /// 器具类型Id
        /// </summary>
        public virtual Guid BoxTypeId { get; set; }
        /// <summary>
        /// 器具类型
        /// </summary>
        public virtual DataDictionaryInfo BoxType { get; set; }
        /// <summary>
        /// 是否使用
        /// </summary>
        public virtual bool IsEnabled { get; set; }
        /// <summary>
        /// 是否破损
        /// </summary>
        public virtual bool IsDamaged { get; set; }
        /// <summary>
        /// 物料记录
        /// </summary>
        public virtual MaterialList MaterialList { get; set; }
        /// <summary>
        /// 不良品记录
        /// </summary>
        public virtual ICollection<BadGoodsList> BadGoodsLists { get; }
        /// <summary>
        /// 备货记录
        /// </summary>
        public virtual ICollection<PickupList> PickupLists { get; }
        /// <summary>
        /// 盘库记录
        /// </summary>
        public virtual ICollection<CycleCountList> CycleCountLists { get; }
        /// <summary>
        /// 补货单记录
        /// </summary>
        public virtual ICollection<ReplenishmentList> ReplenishmentLists { get; }

        public Box()
        {
            IsEnabled = true;
            IsDamaged = false;
            BadGoodsLists = new List<BadGoodsList>();
            PickupLists = new List<PickupList>();
            CycleCountLists = new List<CycleCountList>();
            ReplenishmentLists = new List<ReplenishmentList>();
        }
    }
}
