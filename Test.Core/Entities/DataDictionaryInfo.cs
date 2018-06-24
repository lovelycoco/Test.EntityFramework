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
        public virtual ICollection<Pickup> PickupTypes { get; }
        /// <summary>
        /// 备货状态
        /// </summary>
        public virtual ICollection<Pickup> PickupStatuses { get; set; }
        /// <summary>
        /// 备货区域类型
        /// </summary>
        public virtual ICollection<Pickup> PickupAreaTypes { get; set; }
        /// <summary>
        /// 标签类型
        /// </summary>
        public virtual ICollection<Tag> Tags { get; }
        /// <summary>
        /// 看板单状态
        /// </summary>
        public virtual ICollection<Note> Notes { get; }
        /// <summary>
        /// 模板类型
        /// </summary>
        public virtual ICollection<PickupTemplate> PickupTemplates { get; }
        /// <summary>
        /// 追溯状态
        /// </summary>
        public virtual ICollection<Trace> Traces { get; }
        public DataDictionaryInfo()
        {
            Materials = new List<Material>();
            MaterialLists = new List<MaterialList>();
            CycleCounts = new List<CycleCount>();
            PickupTypes = new List<Pickup>();
            PickupStatuses = new List<Pickup>();
            PickupAreaTypes = new List<Pickup>();
            Tags = new List<Tag>();
            Notes = new List<Note>();
            PickupTemplates = new List<PickupTemplate>();
            Traces = new List<Trace>();
        }
    }
}
