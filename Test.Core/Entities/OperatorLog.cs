using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    public class OperatorLog : BaseEntityOfOperator
    {
        /// <summary>
        /// 操作编码Id
        /// </summary>
        public virtual Guid CodeId { get; set; }
        /// <summary>
        /// 操作编码
        /// </summary>
        public virtual DataDictionaryInfo OperatorCode { get; set; }
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
