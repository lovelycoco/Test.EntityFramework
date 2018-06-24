using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 模板记录信息
    /// </summary>
    public class TemplateList : BaseEntityOfGuid
    {
        /// <summary>
        /// 模板ID
        /// </summary>
        public virtual Guid TemplateId { get; set; }
        /// <summary>
        /// 模板
        /// </summary>
        public virtual PickupTemplate PickupTemplate { get; set; }
        /// <summary>
        /// 物料Id
        /// </summary>
        public virtual Guid MaterialId { get; set; }
        /// <summary>
        /// 物料信息
        /// </summary>
        public virtual Material Material { get; set; }
        /// <summary>
        /// 物料总数
        /// </summary>
        public virtual int TotalQuantity { get; set; }
    }
}
