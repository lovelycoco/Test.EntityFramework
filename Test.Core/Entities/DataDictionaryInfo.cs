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
        public virtual ICollection<Material> MaterialTypes { get; }
        /// <summary>
        /// 物料状态类型
        /// </summary>
        public virtual ICollection<MaterialList> MaterialStatuses { get; }
        /// <summary>
        /// 盘库类型
        /// </summary>
        public virtual ICollection<CycleCount> CountTypes { get; }
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
        //public virtual ICollection<Tag> Tags { get; }
        /// <summary>
        /// 看板单类型
        /// </summary>
        public virtual ICollection<Note> NoteTypes { get; }
        /// <summary>
        /// 看板单状态
        /// </summary>
        public virtual ICollection<Note> NoteStatuses { get; set; }
        /// <summary>
        /// 模板类型
        /// </summary>
        public virtual ICollection<PickupTemplate> TemplateTypes { get; }
        /// <summary>
        /// 追溯状态
        /// </summary>
        public virtual ICollection<Trace> TraceStatuses { get; }
        /// <summary>
        /// 器具类型
        /// </summary>
        public virtual ICollection<Box> BoxeTypes { get; }
        /// <summary>
        /// 操作类型编码
        /// </summary>
        public virtual ICollection<OperatorLog> OperationCodes { get; }
        /// <summary>
        /// 操作日志告警级别
        /// </summary>
        public virtual ICollection<OperatorLog> OperationLogLevels { get; }
        /// <summary>
        /// 操作日志业务类型
        /// </summary>
        public virtual ICollection<OperatorLog> OperationBusinessTypes { get; }
        /// <summary>
        /// 自提来源类型
        /// </summary>
        public virtual ICollection<SelfPickup> OriginalTypes { get; }
        /// <summary>
        /// 不良品操作类型
        /// </summary>
        public virtual ICollection<BadGoodsList> BadGoodsOperationTypes { get; }
        /// <summary>
        /// 业务日志业务类型
        /// </summary>
        public virtual ICollection<BusinessLog> BusinessTypes { get; }
        /// <summary>
        /// 业务日志操作编码
        /// </summary>
        public virtual ICollection<BusinessLog> BusinessOperationCodes { get; }
        /// <summary>
        /// 补货状态
        /// </summary>
        public virtual ICollection<Replenishment> ReplenishmentStatuses { get; }
        public DataDictionaryInfo()
        {
            MaterialTypes = new List<Material>();
            MaterialStatuses = new List<MaterialList>();
            CountTypes = new List<CycleCount>();
            PickupTypes = new List<Pickup>();
            PickupStatuses = new List<Pickup>();
            PickupAreaTypes = new List<Pickup>();
            //Tags = new List<Tag>();
            NoteTypes = new List<Note>();
            NoteStatuses = new List<Note>();
            TemplateTypes = new List<PickupTemplate>();
            TraceStatuses = new List<Trace>();
            BoxeTypes = new List<Box>();
            OperationCodes = new List<OperatorLog>();
            OperationLogLevels = new List<OperatorLog>();
            OperationBusinessTypes = new List<OperatorLog>();
            OriginalTypes = new List<SelfPickup>();
            BadGoodsOperationTypes = new List<BadGoodsList>();
            BusinessTypes = new List<BusinessLog>();
            BusinessOperationCodes = new List<BusinessLog>();
            ReplenishmentStatuses = new List<Replenishment>();
        }
    }
}
