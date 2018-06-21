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
        public virtual string DictionaryName { get; set; }
        public virtual IList<DataDictionaryInfo> DataDictionaryInfos { get; set; }
        public DataDictionary()
        {
            DataDictionaryInfos = new List<DataDictionaryInfo>();
        }
    }
}
