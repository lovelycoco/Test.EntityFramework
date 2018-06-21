using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 备货单
    /// </summary>
    public abstract class Pickup : BaseEntityOfOperator
    {
        /// <summary>
        /// 备货单号
        /// </summary>
        public virtual string PickupNo { get; set; }
        /// <summary>
        /// 是否打印
        /// </summary>
        public virtual bool IsPrinted { get; set; }
        /// <summary>
        /// 打印时间
        /// </summary>
        public virtual DateTime? PrintTime { get; set; }
        /// <summary>
        /// 备货信息记录
        /// </summary>
        public virtual IList<PickupList> PickupLists { get; private set; }
        /// <summary>
        /// 备货类型Id
        /// </summary>
        public virtual Guid DataDictionaryInfoId { get; set; }
        /// <summary>
        /// 备货类型
        /// </summary>
        public virtual DataDictionaryInfo PickUpType { get; set; }
        public Pickup()
        {
            IsPrinted = false;
            PickupLists = new List<PickupList>();
        }


    }

    /// <summary>
    /// 仓储备货
    /// </summary>
    public class StorageAreaPickup : Pickup
    {

    }
    /// <summary>
    /// 分拣区备货
    /// </summary>
    public class PickingAreaPickup : Pickup
    {

    }




}
