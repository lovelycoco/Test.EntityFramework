using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 业务日志记录
    /// </summary>
    public class BusinessLogList : BaseEntityOfGuid
    {
        /// <summary>
        /// 业务日志记录Id
        /// </summary>
        public virtual Guid BusinessLogId { get; set; }
        /// <summary>
        /// 业务日志
        /// </summary>
        public virtual BusinessLog BusinessLog { get; set; }
        /// <summary>
        /// 修改字段
        /// </summary>
        public virtual string ModifiedField { get; set; }
        /// <summary>
        /// 修改字段名称
        /// </summary>
        public virtual string ModifiedFieldName { get; set; }
        /// <summary>
        /// 原始值
        /// </summary>
        public virtual string OriginalValue { get; set; }
        /// <summary>
        /// 目标值
        /// </summary>
        public virtual string TargetValue { get; set; }
    }
}
