using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 不良品
    /// </summary>
    public class BadGoods : BaseEntityOfOperator
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
        /// 总数量
        /// </summary>
        public virtual int TotalQuantity { get; set; }
        /// <summary>
        /// 不良品记录
        /// </summary>
        public virtual ICollection<BadGoodsList> BadGoodsLists { get;}
        public BadGoods()
        {
            BadGoodsLists = new List<BadGoodsList>();
        }
    }
}
