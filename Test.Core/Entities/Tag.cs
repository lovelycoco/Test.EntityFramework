using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 标签信息
    /// </summary>
    public class Tag : BaseEntityOfOperator
    {
        /// <summary>
        /// 标签编号
        /// </summary>
        public virtual string TagCode { get; set; }
        /// <summary>
        /// 是否可用
        /// </summary>
        public virtual bool IsEnabled { get; set; }
        /// <summary>
        /// 字典类型Id
        /// </summary>
        public virtual Guid DataDictionaryInfoId { get; set; }
        /// <summary>
        /// 标签类型
        /// </summary>
        public virtual DataDictionaryInfo TagType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public virtual string TagMemo { get; set; }
        /// <summary>
        /// 物料记录
        /// </summary>
        public virtual MaterialList MaterialList { get; set; }
    }

}
