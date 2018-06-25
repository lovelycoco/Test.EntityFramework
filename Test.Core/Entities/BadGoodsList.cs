using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    public class BadGoodsList : BaseEntityOfOperator
    {
        /// <summary>
        /// 物料ID
        /// </summary>
        public virtual Guid MaterialId { get; set; }
        /// <summary>
        /// 物料信息
        /// </summary>
        public virtual Material Material { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public virtual int Quantity { get; set; }
        /// <summary>
        /// 返修单号
        /// </summary>
        public virtual string RepairNo { get; set; }
    }
}
