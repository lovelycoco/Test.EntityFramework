using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 看板单
    /// </summary>
    public class Note : BaseEntityOfOperator
    {
        /// <summary>
        /// 看板单编号
        /// </summary>
        public virtual string NoteNo { get; set; }
        /// <summary>
        /// 字典信息Id
        /// </summary>
        public virtual Guid DataDictionaryInfoId { get; set; }
        /// <summary>
        /// 看板单状态
        /// </summary>
        public virtual DataDictionaryInfo NoteType { get; set; }
        /// <summary>
        /// 看板单记录
        /// </summary>
        public virtual ICollection<NoteList> NoteLists { get; set; }
        /// <summary>
        /// 备货单
        /// </summary>
        public virtual Pickup Pickup { get; set; }
        public Note()
        {
            NoteLists = new List<NoteList>();
        }
    }
}
