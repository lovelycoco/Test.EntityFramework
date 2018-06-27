using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 追溯
    /// </summary>
    public class Trace : BaseEntityOfOperator
    {
        /// <summary>
        /// 物料记录Id
        /// </summary>
        public virtual Guid MaterialListId { get; set; }
        /// <summary>
        /// 物料记录
        /// </summary>
        public virtual MaterialList MaterialList { get; set; }
        /// <summary>
        /// 追溯状态Id
        /// </summary>
        public virtual Guid TraceStatusId { get; set; }
        /// <summary>
        /// 追溯状态类型
        /// </summary>
        public virtual DataDictionaryInfo TraceStatus { get; set; }
        /// <summary>
        /// 操作描述
        /// </summary>
        public virtual string Operation { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public virtual string Memo { get; set; }
        /// <summary>
        /// 当前数量
        /// </summary>
        public virtual int CurrentQuantity { get; set; }
    }
}
