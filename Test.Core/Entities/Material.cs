using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.Entities
{
    public class Material : BaseEntityOfOperator
    {
        /// <summary>
        /// 物料编码
        /// </summary>
        public virtual string MaterialNum { get; set; }
        /// <summary>
        /// 物料名称
        /// </summary>
        public virtual string MaterialName { get; set; }
        /// <summary>
        /// 收容数量
        /// </summary>
        public virtual int PackageNum { get; set; }
        /// <summary>
        /// 高储
        /// </summary>
        public virtual int Max { get; set; }
        /// <summary>
        /// 低储
        /// </summary>
        public virtual int Min { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public virtual bool IsEnabled { get; set; }
        /// <summary>
        /// 优先级
        /// </summary>
        public virtual int PriorityLevel { get; set; }
        /// <summary>
        /// 供应商Id
        /// </summary>
        public virtual Guid SupplierId { get; set; }
        /// <summary>
        /// 供应商
        /// </summary>
        public virtual Supplier Supplier { get; set; }
        /// <summary>
        /// 库位信息
        /// </summary>
        public virtual StorageBin StorageBin { get; set; }
        /// <summary>
        /// 字典信息Id
        /// </summary>
        public virtual Guid DataDictionaryInfoId { get; set; }
        /// <summary>
        /// 物料类型
        /// </summary>
        public virtual DataDictionaryInfo  DataDictionaryInfo { get; set; }

        public Material()
        {
            IsEnabled = true;
            Max = 0;
            Min = 0;
            PackageNum = 0;
            PriorityLevel = 0;
        }

    }
}
