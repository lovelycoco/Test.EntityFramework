using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 业务日志表
    /// </summary>
    public class BusinessLog : BaseEntityOfOperator
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
        /// 备注
        /// </summary>
        public virtual string Memo { get; set; }
        /// <summary>
        /// 操作表
        /// </summary>
        public virtual string OperationTable { get; set; }
        /// <summary>
        /// 数据表Id
        /// </summary>
        public virtual Guid DataId { get; set; }
        /// <summary>
        /// 业务日志记录
        /// </summary>
        public virtual ICollection<BusinessLogList> BusinessLogLists { get; set; }
        public BusinessLog()
        {
            BusinessLogLists = new List<BusinessLogList>();
        }
    }
}
