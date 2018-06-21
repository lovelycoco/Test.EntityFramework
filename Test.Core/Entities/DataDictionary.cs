using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    /// <summary>
    /// 字典类型表
    /// </summary>
    public class DataDictionary : BaseEntityOfOperator
    {
        /// <summary>
        /// 字典类型名称
        /// </summary>
        public virtual string DictionaryName { get; set; }
        /// <summary>
        /// 字典信息
        /// </summary>
        public virtual IList<DataDictionaryInfo> DataDictionaryInfos { get; set; }
        public DataDictionary()
        {
            DataDictionaryInfos = new List<DataDictionaryInfo>();
        }
    }
}
