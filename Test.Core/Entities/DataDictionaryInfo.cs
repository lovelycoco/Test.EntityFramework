using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 字典信息表
    /// </summary>
    public class DataDictionaryInfo : BaseEntityOfOperator
    {
        /// <summary>
        /// 字典代码
        /// </summary>
        public virtual string DictionaryCode { get; set; }
        /// <summary>
        /// 字典描述
        /// </summary>
        public virtual string DictionaryDescription { get; set; }
        /// <summary>
        /// 字典类型Id
        /// </summary>
        public virtual Guid DataDictionaryId { get; set; }
        /// <summary>
        /// 字典类型
        /// </summary>
        public virtual DataDictionary DataDictionary { get; set; }
        /// <summary>
        /// 物料信息
        /// </summary>
        public virtual ICollection<Material> Materials { get; }
        public DataDictionaryInfo()
        {
            Materials = new List<Material>();
        }
    }
}
