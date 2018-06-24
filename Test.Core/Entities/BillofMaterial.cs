using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 物料清单
    /// </summary>
    public class BillofMaterial : BaseEntityOfOperator
    {
        /// <summary>
        /// 交接单编号
        /// </summary>
        public virtual string BillNo { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public virtual string Memo { get; set; }
        /// <summary>
        /// 接收确认时间
        /// </summary>
        public virtual DateTime ReceiveDate { get; set; }
        /// <summary>
        /// 物料记录集合
        /// </summary>
        public virtual ICollection<MaterialList> MaterialLists { get; set; }
        public BillofMaterial()
        {
            MaterialLists = new List<MaterialList>();
        }

    }
}
