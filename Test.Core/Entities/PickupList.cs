using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 备货记录表
    /// </summary>
    public class PickupList : BaseEntityOfGuid
    {
        public virtual Guid MaterialId { get; set; }
        /// <summary>
        /// 物料信息
        /// </summary>
        public virtual Material Material { get; set; }
        /// <summary>
        /// 物料数量
        /// </summary>
        public virtual int MaterialNum { get; set; }
        /// <summary>
        /// 备货单Id
        /// </summary>
        public virtual Guid PickingListId { get; set; }
        /// <summary>
        /// 备货单信息
        /// </summary>
        public virtual Pickup PickingList { get; set; }
        public PickupList()
        {
            MaterialNum = 0;
        }
    }
}
