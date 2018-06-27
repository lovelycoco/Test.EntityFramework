using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 操作日志
    /// </summary>
    public class OperatorLog : BaseEntityOfOperator
    {
        /// <summary>
        /// 业务类型Id
        /// </summary>
        public virtual Guid BusinessTypeId { get; set; }
        /// <summary>
        /// 业务类型
        /// </summary>
        public virtual DataDictionaryInfo BusinessType { get; set; }
        /// <summary>
        /// 操作编码Id
        /// </summary>
        public virtual Guid OperationCodeId { get; set; }
        /// <summary>
        /// 操作编码
        /// </summary>
        public virtual DataDictionaryInfo OperationCode { get; set; }
        /// <summary>
        /// 操作内容
        /// </summary>
        public virtual string Operation { get; set; }
        /// <summary>
        /// 告警级别Id
        /// </summary>
        public virtual Guid LevelId { get; set; }
        /// <summary>
        /// 告警级别
        /// </summary>
        public virtual DataDictionaryInfo LogLevel { get; set; }
        /// <summary>
        /// 操作备注
        /// </summary>
        public virtual string Memo { get; set; }

    }
}
