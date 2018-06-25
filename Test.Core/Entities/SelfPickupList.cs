using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    public class SelfPickupList : BaseEntityOfGuid
    {
        /// <summary>
        /// 自提Id
        /// </summary>
        public virtual Guid SelfId { get; set; }
        /// <summary>
        /// 自提单
        /// </summary>
        public virtual SelfPickup SelfPickup { get; set; }
        /// <summary>
        /// 物料Id
        /// </summary>
        public virtual Guid MaterialId  { get; set; }
        /// <summary>
        /// 物料信息
        /// </summary>
        public virtual Material Material { get; set; }
        /// <summary>
        /// 自提数量
        /// </summary>
        public virtual int Quantity { get; set; }
    }
}
