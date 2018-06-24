using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 看板单记录
    /// </summary>
    public class NoteList : BaseEntityOfGuid
    {
        /// <summary>
        /// 看板单ID
        /// </summary>
        public virtual Guid NoteId { get; set; }
        /// <summary>
        /// 看板单信息
        /// </summary>
        public virtual Note Note { get; set; }
        /// <summary>
        /// 物料Id
        /// </summary>
        public virtual Guid MaterialId { get; set; }
        /// <summary>
        /// 物料信息
        /// </summary>
        public virtual Material Material { get; set; }
        /// <summary>
        /// 总数
        /// </summary>
        public virtual int TotalQuantity { get; set; }
    }
}
