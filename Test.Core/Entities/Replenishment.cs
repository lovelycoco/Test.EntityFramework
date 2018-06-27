using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 补货信息
    /// </summary>
    public class Replenishment : BaseEntityOfOperator
    {
        /// <summary>
        /// 补货时间
        /// </summary>
        public virtual DateTime ReplenishmentDate { get; set; }
        /// <summary>
        /// 补货状态Id
        /// </summary>
        public virtual Guid ReplenishmentStatusId { get; set; }
        /// <summary>
        /// 补货状态
        /// </summary>
        public virtual DataDictionaryInfo ReplenishmentStatus { get; set; }
        /// <summary>
        /// 补货单记录
        /// </summary>
        public virtual ICollection<ReplenishmentList> ReplenishmentLists { get; }
        public Replenishment()
        {
            ReplenishmentLists = new List<ReplenishmentList>();
        }
    }
}
