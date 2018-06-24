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
        /// 物料类型
        /// </summary>
        public virtual ICollection<Material> Materials { get; }
        /// <summary>
        /// 物料状态类型
        /// </summary>
        public virtual ICollection<MaterialList> MaterialLists { get; }
        /// <summary>
        /// 盘库类型
        /// </summary>
        public virtual ICollection<CycleCount> CycleCounts { get; }
        /// <summary>
        /// 备货类型
        /// </summary>
        public virtual ICollection<Pickup> Pickups { get; }
        public virtual ICollection<Tag> Tags { get; }
        public DataDictionaryInfo()
        {
            Materials = new List<Material>();
            MaterialLists = new List<MaterialList>();
            CycleCounts = new List<CycleCount>();
            Pickups = new List<Pickup>();
            Tags = new List<Tag>();
        }
    }
}
